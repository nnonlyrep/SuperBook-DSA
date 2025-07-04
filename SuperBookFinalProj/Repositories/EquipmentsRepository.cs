﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SuperBookFinalProj.Models;

namespace SuperBookFinalProj.Repositories
{

    public class EquipmentsRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://sfmtzyrligymzdyhalll.supabase.co";
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InNmbXR6eXJsaWd5bXpkeWhhbGxsIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTEzNzg0ODAsImV4cCI6MjA2Njk1NDQ4MH0.XpXKqFJSA84YsX4VxENRkuy6JO3-qwu10NrjkTkTN88";
        private readonly string _tableName = "equipment";

        public EquipmentsRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("apikey", _apiKey);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<int> CreateAsync(Equipments equipment)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            };

            string json = JsonSerializer.Serialize(equipment, options);
            Console.WriteLine("Request JSON: " + json);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Remove("Prefer");
            _httpClient.DefaultRequestHeaders.Add("Prefer", "return=representation");

            var response = await _httpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response Body: " + responseBody);

            response.EnsureSuccessStatusCode();

            var createdEquipments = JsonSerializer.Deserialize<List<Equipments>>(responseBody, options);

            Equipments createdEquipment = createdEquipments?.FirstOrDefault();
            return createdEquipment?.Id ?? 0;
        }

        public async Task<List<Equipments>> GetAllAsync()
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var equipments = JsonSerializer.Deserialize<List<Equipments>>(responseBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return equipments;
        }

        public async Task<Equipments> GetByIdAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var equipments = JsonSerializer.Deserialize<List<Equipments>>(responseBody);
            return equipments.Count > 0 ? equipments[0] : null;
        }

        public async Task<bool> UpdateAsync(Equipments equipment)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{equipment.Id}";

            var updateData = new Dictionary<string, object>
    {
        { "name", equipment.Name },
        { "type", equipment.Type },
        { "quantity", equipment.Quantity }
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

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"❌ Update failed. Response: {response.StatusCode}");
                Console.WriteLine($"Response Body: {responseBody}");
                return false;
            }

            Console.WriteLine($"✅ Update successful!");
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";

            var response = await _httpClient.DeleteAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"✅ Equipment with ID {id} deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine($"❌ Delete failed. Response: {response.StatusCode}");
                Console.WriteLine($"Response Body: {responseBody}");
                return false;
            }
        }
        // ✅ Add the missing method to update equipment quantity
        public async Task UpdateQuantityAsync(int equipmentId, int newQuantity)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{equipmentId}";

            var json = JsonSerializer.Serialize(new { quantity = newQuantity }); // Prepare JSON body
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // ✅ Ensure headers are correctly set
            _httpClient.DefaultRequestHeaders.Remove("Prefer");
            _httpClient.DefaultRequestHeaders.Add("Prefer", "return=minimal");

            var response = await _httpClient.PatchAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Failed to update quantity. Error: {errorMessage}");
            }
        }

        public async Task<bool> RestoreQuantityAsync(int equipmentId, int quantityToRestore)
        {
            if (equipmentId == 0)
            {
                Console.WriteLine("⚠️ Invalid Equipment ID: 0");
                return false;
            }

            var url = $"{_baseUrl}/rest/v1/equipments?id=eq.{equipmentId}";

            var existingEquipments = await GetAllAsync();
            var equipment = existingEquipments.FirstOrDefault(eq => eq.Id == equipmentId);

            if (equipment == null)
            {
                Console.WriteLine($"❌ Equipment with ID {equipmentId} not found.");
                return false;
            }

            int updatedQuantity = equipment.Quantity + quantityToRestore;

            var updateData = new { quantity = updatedQuantity };
            var json = JsonSerializer.Serialize(updateData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PatchAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"✅ Restored {quantityToRestore} to Equipment ID {equipmentId}");
                return true;
            }

            Console.WriteLine("❌ Failed to restore quantity.");
            return false;
        }


    }
}