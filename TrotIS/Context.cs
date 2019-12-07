using System;
using Microsoft.EntityFrameworkCore;


namespace TrotIS.Shared
{
    public class Context: DbContext
    {
        

        public DbSet<User> Users { get; set; }
        public DbSet<Scooter> Scooters { get; set; }
        public DbSet<Address> Addresses { get; set; }
   
        public Context()
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
            modelBuilder.Entity<User>()
                .HasOne(s => s.Address);


            modelBuilder.Entity<User>().HasData(new User("catalinbelu21@gmail.com", "Catalin", "Belu", 
                "0770796616", DateTime.Parse("06/16/1999"), EnumLists.SocialClass.student));
            modelBuilder.Entity<Scooter>().HasData(new Scooter("Yamaha", "v2.0", 20, 14, 60, 120, 25, 15));
            modelBuilder.Entity<Address>().HasData(new Address("Romania", "Iasi", "Iasi", "Moara de foc", 35, "Solomon", 7, "7A"));
        }
    }
}
