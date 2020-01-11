using System;
using Microsoft.EntityFrameworkCore;
using TrotIS.Shared;

namespace UserAPI.Data
{
    public class Context: DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
   
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();

        }

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

            modelBuilder.Entity<User>().HasData(User.Create("catalinbelu21@gmail.com", "parola", "Catalin", "Belu", 
                "0770796616", DateTime.Parse("06/12/1999"), EnumLists.SocialClass.student));

            modelBuilder.Entity<Address>().HasData(Address.Create("Romania", "Iasi", "Moara de foc", 35));

        }
    }
}
