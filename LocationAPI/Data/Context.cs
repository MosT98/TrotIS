using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LocationAPI.Data
{
    public class Context: DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationsToScooters> LinkLocationsToScooterInstances { get; set; }

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
            Location location = Location.Create("6719bc69-b700-40a3-8c00-ecf14eb977cd");
            modelBuilder.Entity<Location>()
                .HasData(location);

            modelBuilder.Entity<LocationsToScooters>()
                .HasKey(a => new { a.LocationID, a.ScooterInstanceID });
            modelBuilder.Entity<LocationsToScooters>()
                .HasData(LocationsToScooters.CreateMany(location.LocationID.ToString(), scooters));
        }
    }
}
