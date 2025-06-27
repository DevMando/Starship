using Microsoft.EntityFrameworkCore;
using StarshipWebApp.Models;

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
        }


        public DbSet<Starship> Starships { get; set; }
    }
}
