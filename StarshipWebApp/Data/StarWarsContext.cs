using Microsoft.EntityFrameworkCore;
using StarshipWebApp.Models;
using System.Text.Json;

namespace StarshipWebApp.Data
{
    public class StarWarsContext : DbContext
    {
        public StarWarsContext(DbContextOptions<StarWarsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Starship>()
                .Property(s => s.Pilots)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions?)null));

            modelBuilder.Entity<Starship>()
                .Property(s => s.Films)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions?)null));
        }

        public DbSet<Starship> Starships { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
