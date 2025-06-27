/**
 *  Author: Armando Fernandez
 *  Date: 06.27.2025
 *  File: JsonUtilities.cs
 *  Description: This static utility class centralizes JSON serialization settings for the application.
 *  It registers custom converters such as NullableLongConverter and NullableIntConverter to gracefully handle 
 *  inconsistent numeric values from the SWAPI Starship resource (e.g., "unknown", "n/a", or stringified numbers).
**/

using System.Text.Json;
using StarshipWebApp.Utilities.Converters;

namespace StarshipWebApp.Utilities
{
    public static class JsonUtilities
    {
        public static JsonSerializerOptions DefaultOptions()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new NullableLongConverter());
            options.Converters.Add(new NullableIntConverter());
            return options;
        }

    }
}
