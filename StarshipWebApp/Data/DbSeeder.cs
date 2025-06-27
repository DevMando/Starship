/**
 *  Author: Armando Fernandez
 *  Date: 06.27.2025
 *  File: DbSeeder.cs
 *  Description: This static utility class is responsible for seeding the local database with Starship data 
 *  retrieved from the SWAPI service. It checks for existing entries to prevent duplicate inserts, and is 
 *  typically invoked during application startup.
 */

using StarshipWebApp.Services;

namespace StarshipWebApp.Data
{
    public static class DbSeeder
    {
        public static async Task SeedStarshipsAsync(StarWarsContext context, SwapiService swapiService)
        {
            if (!context.Starships.Any())
            {
                var starships = await swapiService.GetStarshipsAsync();
                context.Starships.AddRange(starships);
                await context.SaveChangesAsync();
            }
        }
    }
}
