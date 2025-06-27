/**
 *  Author: Armando Fernandez
 *  Date: 06.27.2025
 *  File: NullableIntConverter.cs
 *  Description: This custom JSON converter handles deserialization of integer values from JSON where the values 
 *  may be inconsistently represented as strings or actual numbers. It safely converts values like "15", 15, or "unknown" 
 *  into nullable integers (`int?`), allowing for flexibility in parsing SWAPI data such as "crew", "passengers", etc.
 *  
 *  NOTE: This approach was inspired by a suggestion from ChatGPT during development of the Star Wars take-home exercise.
 *  ChatGPT recommended creating per-type converters to manage inconsistent API data representations cleanly.
 */

using System.Text.Json;
using System.Text.Json.Serialization;

namespace StarshipWebApp.Utilities.Converters
{
    public class NullableIntConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out var number))
                return number;

            if (reader.TokenType == JsonTokenType.String)
            {
                var stringValue = reader.GetString();
                if (int.TryParse(stringValue, out var result))
                    return result;

                return null;
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
            else
                writer.WriteNullValue();
        }
    }
}