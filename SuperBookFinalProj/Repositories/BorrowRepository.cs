using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SuperBookFinalProj.Models;

namespace SuperBookFinalProj.Repositories
{
    public class BorrowRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://tgxxkstbeetnhetjcyen.supabase.co";
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InRneHhrc3RiZWV0bmhldGpjeWVuIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDA0MDM5MjYsImV4cCI6MjA1NTk3OTkyNn0.lMBzLb9bR2Z0wDnIDfg38_VvtgELhNZgzz0UlYCAUSQ";
        private readonly string _tableName = "borrows";

        // Constructor
        public BorrowRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("apikey", _apiKey);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // ----------------- CREATE BORROW RECORD -----------------
        public async Task<int> CreateAsync(Borrow borrow)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };

            string json = JsonSerializer.Serialize(borrow, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Remove("Prefer");
            _httpClient.DefaultRequestHeaders.Add("Prefer", "return=representation");

            var response = await _httpClient.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            var createdBorrows = JsonSerializer.Deserialize<List<Borrow>>(responseBody, options);

            return createdBorrows?.FirstOrDefault()?.Id ?? 0;
        }

        // ----------------- GET ALL BORROW RECORDS -----------------
        public async Task<List<Borrow>> GetAllAsync()
        {
            var url = $"{_baseUrl}/rest/v1/borrows";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var borrows = JsonSerializer.Deserialize<List<Borrow>>(responseBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return borrows;
        }



        // ----------------- GET BORROW RECORD BY ID -----------------
        public async Task<Borrow> GetByIdAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var borrows = JsonSerializer.Deserialize<List<Borrow>>(responseBody);
            return borrows.Count > 0 ? borrows[0] : null;
        }

        // ----------------- CANCEL BORROW RECORD -----------------
        // ----------------- CANCEL BORROW RECORD (Update Status) -----------------
        public async Task<bool> CancelBorrowAsync(int borrowId)
        {
            try
            {
                var url = $"{_baseUrl}/rest/v1/borrows?id=eq.{borrowId}";

                // ✅ Check if the borrow record exists before updating
                var existingBorrow = await GetByIdAsync(borrowId);
                if (existingBorrow == null)
                {
                    Debug.WriteLine($"⚠️ Borrow record ID {borrowId} not found.");
                    return false;
                }

                // ✅ Update the status to "Canceled"
                existingBorrow.Status = "Canceled";

                var json = JsonSerializer.Serialize(new { status = "Canceled" });
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                _httpClient.DefaultRequestHeaders.Remove("Prefer");
                _httpClient.DefaultRequestHeaders.Add("Prefer", "return=representation");

                var response = await _httpClient.PatchAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine($"✅ Successfully updated borrow ID {borrowId} to 'Canceled'.");
                    return true;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"❌ Error updating borrow ID {borrowId}: {response.StatusCode}, {errorResponse}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"❌ Exception updating borrow ID {borrowId}: {ex.Message}");
                return false;
            }
        }









    }
}
