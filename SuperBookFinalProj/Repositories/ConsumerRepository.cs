using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SuperBookFinalProj.Models;
using System.Net.Http;

namespace SuperBookFinalProj.Repositories
{
    public class ConsumerRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://tgxxkstbeetnhetjcyen.supabase.co";
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InRneHhrc3RiZWV0bmhldGpjeWVuIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDA0MDM5MjYsImV4cCI6MjA1NTk3OTkyNn0.lMBzLb9bR2Z0wDnIDfg38_VvtgELhNZgzz0UlYCAUSQ";
        private readonly string _tableName = "consumers";

       

        // Constructor
        public ConsumerRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("apikey", _apiKey);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // ----------------- CREATE -----------------
        public async Task<int> CreateAsync(Consumer consumer)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };

            string json = JsonSerializer.Serialize(consumer, options);
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
            var createdConsumers = JsonSerializer.Deserialize<List<Consumer>>(responseBody, options);

            // ✅ Return the ID of the first inserted consumer or 0 if null
            Consumer createdConsumer = createdConsumers?.FirstOrDefault();
            return createdConsumer?.id ?? 0;
        }






        // ----------------- READ ALL -----------------
        public async Task<List<Consumer>> GetAllAsync()
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Consumer>>(responseBody);
        }

        // ----------------- READ BY ID -----------------
        public async Task<Consumer> GetByIdAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var consumers = JsonSerializer.Deserialize<List<Consumer>>(responseBody);
            return consumers.Count > 0 ? consumers[0] : null;
        }

        // ----------------- UPDATE -----------------
        public async Task UpdateAsync(Consumer consumer)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{consumer.id}";
            var json = JsonSerializer.Serialize(consumer);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PatchAsync(url, content);
            response.EnsureSuccessStatusCode();
        }

        // ----------------- DELETE -----------------
        public async Task DeleteAsync(int id)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?id=eq.{id}";
            var response = await _httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
        }
    }
}
