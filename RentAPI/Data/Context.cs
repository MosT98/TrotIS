using Microsoft.EntityFrameworkCore;
using System;

namespace RentAPI.Data
{
    public class Context : DbContext
    {
        public DbSet<Rent> Rents { get; set; }

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
            var rent = Rent.Create("e5cf7f23-0146-4a4a-8322-d1209cf737d0", "843e8cb6-4928-4bb8-85ca-2412ff36a3eb", "47364138-912d-4ea2-b59f-eca02e4d8db7");
            modelBuilder.Entity<Rent>().HasData(rent);
        }

    }
}
