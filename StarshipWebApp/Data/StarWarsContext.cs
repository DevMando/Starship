using Microsoft.EntityFrameworkCore;
using StarshipWebApp.Models;

namespace StarshipWebApp.Data
{
    public class StarWarsContext
    {
        public class StarWars : DbContext
        {
            public StarWars(DbContextOptions<StarWars> options) : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }


            public DbSet<Starship> Starships { get; set; }
        }
    }
}
