using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationAPI.Data
{
    public class Context: DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=trotis_db;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<string> scooters = new List<string>();
            scooters.Add("65a1ecd5-5ac1-434b-8c35-1bedcee04dd4");
            modelBuilder.Entity<Location>()
                .HasData(Location.Create("6719bc69-b700-40a3-8c00-ecf14eb977cd", scooters));
        }
    }
}
