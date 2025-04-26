﻿using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using MiPrimerAPI.Controllers.DTOs;


namespace MiPrimerAPI.Controllers.servicio
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync("https://reqres.in/api/users?page=1");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<UserResponse>(content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return users?.Data ?? new List<User>();
        }
    }
}
