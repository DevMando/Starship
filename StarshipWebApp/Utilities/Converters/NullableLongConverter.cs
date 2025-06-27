/**
 *  Author: Armando Fernandez
 *  Date: 06.27.2025
 *  File: NulableLongConverter.cs
 *  Description: When analyzing the Starship json data retrieved with SWAPI, I noticed some values for specific fields 
 *  such as "passengers" had conflicting data type values (int/string). 
 *  Some fields were represented as strings in the JSON, while others were long ("n/a") or ("36000000").
 *  This converter is designed to handle such instances of data type differences when serializing data.
 *  
 *  NOTE: I brought this issue up to ChatGPT when analyzing the Starship data, and it suggested creating a custom converter.
 *  after prompting it, to create a Starship class on the fly, to avoid typing every property manually.
 *  ChatGPT provided a basic structure for the converter.
 */

using System.Text.Json.Serialization;
using System.Text.Json;

namespace StarshipWebApp.Utilities.Converters
{
    public class NullableLongConverter : JsonConverter<long?>
    {
        public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out var number))
                return number;

            // If the token is a string (e.g., "36000000" or "unknown")
            if (reader.TokenType == JsonTokenType.String)
            {
                var stringValue = reader.GetString();
                if (long.TryParse(stringValue, out var result))
                    return result;

                return null;
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
            else
                writer.WriteNullValue();
        }
    }
}
