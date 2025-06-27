using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StarshipWebApp.Models
{
    public class Starship
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("cost_in_credits")]
        public long CostInCredits { get; set; }

        [JsonPropertyName("length")]
        public string Length { get; set; }

        [JsonPropertyName("max_atmosphering_speed")]
        public int? MaxAtmospheringSpeed { get; set; } = null;

        [JsonPropertyName("crew")]
        public string Crew { get; set; }

        [JsonPropertyName("passengers")]
        public int? Passengers { get; set; } = null;

        [JsonPropertyName("cargo_capacity")]
        public long? CargoCapacity { get; set; } = null;

        [JsonPropertyName("consumables")]
        public string Consumables { get; set; }

        [JsonPropertyName("hyperdrive_rating")]
        [Precision(5, 2)]
        public decimal HyperdriveRating { get; set; }

        [JsonPropertyName("MGLT")]
        public int? MGLT { get; set; } = null;

        [JsonPropertyName("starship_class")]
        public string StarshipClass { get; set; }

        public int? StarshipClassId { get; set; } = null;

        [JsonPropertyName("pilots")]
        public string Pilots { get; set; }

        [JsonPropertyName("films")]
        public string Films { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("edited")]
        public DateTime Edited { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
