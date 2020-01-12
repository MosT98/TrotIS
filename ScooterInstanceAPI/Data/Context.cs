using Microsoft.EntityFrameworkCore;

namespace ScooterInstanceAPI.Data
{
    public class Context : DbContext
    {

        public DbSet<ScooterInstance> ScooterInstances { get; set; }
        public DbSet<Scooter> Scooters { get; set; }

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
                //.WithMany(b=> b.ScooterInstances);

            //modelBuilder.Entity<Scooter>()
            //    .HasMany(a => a.ScooterInstances);
            //var scooter = Scooter.Create("Yamaha", "v2", 50, 15, 25, 150, 500, 85);
            //modelBuilder.Entity<Scooter>()
            //    .HasData(scooter);

            //modelBuilder.Entity<ScooterInstance>()
            //    .HasData(ScooterInstance.Create(7, scooter));
            //Scooter.Create("Yamaha", "v2", 50, 15, 25, 150, 500, 85)));
        }
    }
}
