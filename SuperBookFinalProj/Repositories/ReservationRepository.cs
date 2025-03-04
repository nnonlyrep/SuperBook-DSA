using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SuperBookFinalProj.Models;

namespace SuperBookFinalProj.Repositories
{
    public class ReservationRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://tgxxkstbeetnhetjcyen.supabase.co";
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InRneHhrc3RiZWV0bmhldGpjeWVuIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDA0MDM5MjYsImV4cCI6MjA1NTk3OTkyNn0.lMBzLb9bR2Z0wDnIDfg38_VvtgELhNZgzz0UlYCAUSQ";
        private readonly string _tableName = "reservations";

        // Constructor
        public ReservationRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("apikey", _apiKey);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // ----------------- CREATE RESERVATION -----------------
        public async Task<int> CreateAsync(Reservation reservation)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };

            string json = JsonSerializer.Serialize(reservation, options);
            Console.WriteLine("Request JSON: " + json);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // ✅ Ensure the 'Prefer' header is added for returning the inserted record
            _httpClient.DefaultRequestHeaders.Remove("Prefer"); // Remove in case it was already added
            _httpClient.DefaultRequestHeaders.Add("Prefer", "return=representation");

            var response = await _httpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response Body: " + responseBody);

            response.EnsureSuccessStatusCode();

            // ✅ Deserialize as a list because Supabase returns an array
            var createdReservations = JsonSerializer.Deserialize<List<Reservation>>(responseBody, options);

            // ✅ Return the ID of the first inserted reservation or 0 if null
            Reservation createdReservation = createdReservations?.FirstOrDefault();
            return createdReservation?.id ?? 0;
        }

        // ----------------- READ ALL RESERVATIONS -----------------
        public async Task<List<Reservation>> GetAllAsync()
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var reservations = JsonSerializer.Deserialize<List<Reservation>>(responseBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return reservations;
        }

        // ----------------- READ RESERVATION BY ID -----------------
        public async Task<Reservation> GetByIdAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var reservations = JsonSerializer.Deserialize<List<Reservation>>(responseBody);
            return reservations.Count > 0 ? reservations[0] : null;
        }

        // ----------------- DELETE RESERVATION -----------------
        public async Task<bool> DeleteAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";

            var response = await _httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return true; // ✅ Successfully deleted
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"❌ Failed to delete reservation. Error: {errorMessage}");
            }
        }
        public async Task<List<ReservationView>> GetAllReservationsWithDetailsAsync()
        {
            var url = $"{_baseUrl}/rest/v1/rpc/get_reservations_with_details"; // Call stored procedure or RPC
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var reservations = JsonSerializer.Deserialize<List<ReservationView>>(responseBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return reservations;
        }
        public async Task<bool> DeleteByRoomIdAsync(int roomId)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?room_id=eq.{roomId}";

            var response = await _httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"✅ Successfully deleted all reservations for Room ID {roomId}");
                return true;
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"❌ Failed to delete reservations. Error: {errorMessage}");
            }
        }


    }
}
