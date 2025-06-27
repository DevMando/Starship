/**
 *  Author: Armando Fernandez
 *  Date: 06.27.2025
 *  File: NullableDecimalConverter.cs
 *  Description: This custom JSON converter handles deserialization of decimal values from JSON where the values 
 *  may be inconsistently represented as strings or actual numbers. It safely converts values like "2.0", 2.0, or "unknown" 
 *  into nullable decimals (`decimal?`), allowing for flexibility in parsing SWAPI data such as "hyperdrive_rating" or other
 *  float-like values.
 *  
 */

using System.Text.Json;
using System.Text.Json.Serialization;

namespace StarshipWebApp.Utilities.Converters
{
    public class NullableDecimalConverter : JsonConverter<decimal?>
    {
        public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetDecimal(out var number))
                return number;

            if (reader.TokenType == JsonTokenType.String)
            {
                var stringValue = reader.GetString();
                if (decimal.TryParse(stringValue, out var result))
                    return result;

                return null;
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
            else
                writer.WriteNullValue();
        }
    }
}
