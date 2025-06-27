/**
 *  Author: Armando Fernandez
 *  Date: 06.27.2025
 *  File: SwapiService.cs
 *  Description: This service is responsible for retrieving paginated Starship data from the Star Wars API (SWAPI).
 *  It deserializes the incoming JSON into strongly-typed Starship objects using custom JSON converters for data 
 *  consistency and type flexibility. The service also provides the option to seed the application's local database.
 */

using System.Net.Http;
using System.Text.Json;
using StarshipWebApp.Models;
using StarshipWebApp.Utilities;
using StarshipWebApp.Data;

namespace StarshipWebApp.Services
{
    public class SwapiService
    {
        private readonly HttpClient _httpClient;
        private readonly StarWarsContext _starWarsContext;

        public SwapiService(HttpClient httpClient, StarWarsContext starWarsContext)
        {
            _httpClient = httpClient;
            _starWarsContext = starWarsContext;
        }

        public async Task<List<Starship>> GetStarshipsAsync()
        {
            var url = "https://swapi.dev/api/starships/";
            var starships = new List<Starship>();

            while (url != null)
            {
                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    // Optional: Log or throw a custom exception
                    throw new HttpRequestException($"Failed to retrieve data from SWAPI: {response.StatusCode}");
                }

                var content = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<StarshipApiResponse>(content, JsonUtilities.DefaultOptions());

                if (result?.Results != null)
                    starships.AddRange(result.Results);

                url = result?.Next;
            }

            return starships;
        }
    }

    public class StarshipApiResponse
    {
        public int Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<Starship> Results { get; set; } = new();
    }
}