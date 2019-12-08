using Microsoft.EntityFrameworkCore;
using TrotIS.Shared;

namespace ScooterInstanceAPI.Data
{
    public class Context : DbContext
    {

        public DbSet<ScooterInstance> ScooterInstances { get; set; }

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
            modelBuilder.Entity<ScooterInstance>()
                .HasOne(a => a.Scooter);

            modelBuilder.Entity<ScooterInstance>()
                .HasData(ScooterInstance.Create(7, new Scooter("Yamaha", "v7", 25, 15, 25, 200, 500, 90)));

        }
    }
}
