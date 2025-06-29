using Microsoft.EntityFrameworkCore;
using StarshipWebApp.Utilities.Converters;
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
        [JsonConverter(typeof(NullableLongConverter))]
        public long? CostInCredits { get; set; } = null;

        [JsonPropertyName("length")]
        public string Length { get; set; }

        [JsonPropertyName("max_atmosphering_speed")]
        [JsonConverter(typeof(NullableIntConverter))]
        public int? MaxAtmospheringSpeed { get; set; } = null;

        [JsonPropertyName("crew")]
        public string Crew { get; set; }

        [JsonPropertyName("passengers")]
        [JsonConverter(typeof(NullableIntConverter))]
        public int? Passengers { get; set; } = null;

        [JsonPropertyName("cargo_capacity")]
        [JsonConverter(typeof(NullableLongConverter))]
        public long? CargoCapacity { get; set; } = null;

        [JsonPropertyName("consumables")]
        public string Consumables { get; set; }

        [Precision(5, 2)]
        [JsonPropertyName("hyperdrive_rating")]
        [JsonConverter(typeof(NullableDecimalConverter))]
        public decimal? HyperdriveRating { get; set; } = null;

        [JsonPropertyName("MGLT")]
        public int? MGLT { get; set; } = null;

        [JsonPropertyName("starship_class")]
        public string StarshipClass { get; set; }

        public int? StarshipClassId { get; set; } = null;

        [JsonPropertyName("pilots")]
        public List<string>? Pilots { get; set; } = null;

        [JsonPropertyName("films")]
        public List<string>? Films { get; set; } = null;

        [JsonPropertyName("created")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [JsonPropertyName("edited")]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        [JsonPropertyName("url")]
        public string? Url { get; set; } = null;

    }
}
