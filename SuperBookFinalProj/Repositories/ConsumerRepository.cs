﻿using System;
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
        private readonly string _baseUrl = "https://sfmtzyrligymzdyhalll.supabase.co";
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InNmbXR6eXJsaWd5bXpkeWhhbGxsIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTEzNzg0ODAsImV4cCI6MjA2Njk1NDQ4MH0.XpXKqFJSA84YsX4VxENRkuy6JO3-qwu10NrjkTkTN88";
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
            var consumers = JsonSerializer.Deserialize<List<Consumer>>(responseBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return consumers;
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
                throw new Exception($"❌ Failed to delete user. Error: {errorMessage}");
            }
        }

        // ----------------- AUTHENTICATION -----------------
        public async Task<Consumer> AuthenticateUserAsync(string username, string password)
        {
            var url = $"{_baseUrl}/rest/v1/{_tableName}?user_name=eq.{username}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<List<Consumer>>(responseBody);

            if (users.Count == 0)
                return null; // ❌ No user found

            Consumer user = users[0];

            // 🔹 Verify hashed password
            if (BCrypt.Net.BCrypt.Verify(password, user.password))
                return user; // ✅ Password matches

            return null; // ❌ Password incorrect
        }


    }
}
