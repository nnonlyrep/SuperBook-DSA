using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SuperBookFinalProj.Models;

namespace SuperBookFinalProj.Repositories
{
    public class RoomRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://tgxxkstbeetnhetjcyen.supabase.co";
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InRneHhrc3RiZWV0bmhldGpjeWVuIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDA0MDM5MjYsImV4cCI6MjA1NTk3OTkyNn0.lMBzLb9bR2Z0wDnIDfg38_VvtgELhNZgzz0UlYCAUSQ";
        private readonly string _tableName = "room";

        // Constructor
        public RoomRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("apikey", _apiKey);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // ----------------- CREATE -----------------
        public async Task<int> CreateAsync(Room room)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            };

            string json = JsonSerializer.Serialize(room, options);
            Console.WriteLine("Request JSON: " + json);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // ✅ Ensure the 'Prefer' header is added for returning the inserted record
            _httpClient.DefaultRequestHeaders.Remove("Prefer");
            _httpClient.DefaultRequestHeaders.Add("Prefer", "return=representation");

            var response = await _httpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response Body: " + responseBody);

            response.EnsureSuccessStatusCode();

            // ✅ Deserialize as a list because Supabase returns an array
            var createdRooms = JsonSerializer.Deserialize<List<Room>>(responseBody, options);

            // ✅ Return the ID of the first inserted room or 0 if null
            Room createdRoom = createdRooms?.FirstOrDefault();
            return createdRoom?.id ?? 0;

       

        }

        // ----------------- READ ALL -----------------
        public async Task<List<Room>> GetAllAsync()
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var rooms = JsonSerializer.Deserialize<List<Room>>(responseBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return rooms;
        }

        // ----------------- READ BY ID -----------------
        public async Task<Room> GetByIdAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var rooms = JsonSerializer.Deserialize<List<Room>>(responseBody);
            return rooms.Count > 0 ? rooms[0] : null;
        }

        // ----------------- UPDATE -----------------
        public async Task<bool> UpdateAsync(Room room)
        {
            var url = $"{_baseUrl}/rest/v1/room?id=eq.{room.id}";

            var updateData = new Dictionary<string, object>
    {
        { "room_number", room.room_number },
        { "room_type", room.room_type },
        { "capacity", room.capacity },
        { "location", room.location }
    };

            string json = JsonSerializer.Serialize(updateData, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            Console.WriteLine($"PATCH Request URL: {url}");
            Console.WriteLine($"PATCH Request JSON: {json}");

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Remove("Prefer");
            _httpClient.DefaultRequestHeaders.Add("Prefer", "return=representation");

            var response = await _httpClient.PatchAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"Update Response: {response.StatusCode}");
            Console.WriteLine($"Response Body: {responseBody}");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Supabase Update Error: {responseBody}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return response.IsSuccessStatusCode;
        }




        // ----------------- DELETE -----------------
        public async Task<bool> DeleteAsync(int roomId)
        {
            try
            {
                var reservationRepo = new ReservationRepository();

                // Step 1: Delete all reservations for this room
                Console.WriteLine($"🔄 Deleting reservations for Room ID: {roomId}...");
                await reservationRepo.DeleteByRoomIdAsync(roomId);
                Console.WriteLine("✅ All related reservations deleted.");

                // Step 2: Delete the room itself
                var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{roomId}";
                var response = await _httpClient.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"✅ Room {roomId} deleted successfully.");
                    return true;
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"❌ Failed to delete room. Error: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error deleting room: {ex.Message}");
                throw;
            }
        }

    }
}
