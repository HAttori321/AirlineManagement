using System.Collections.Generic;
using System.Data.Entity;

namespace AirlineManagement.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<AirplaneType> AirplaneTypes { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasOptional(c => c.City)
                .WithMany(c => c.Countries)
                .HasForeignKey(c => c.CityId);

            modelBuilder.Entity<Account>()
                .HasMany(a => a.Flights)
                .WithRequired(f => f.Account)
                .HasForeignKey(f => f.AccountId);

            modelBuilder.Entity<City>()
                .HasMany(c => c.Flights)
                .WithRequired(f => f.City)
                .HasForeignKey(f => f.CityId);

            modelBuilder.Entity<AirplaneType>()
                .HasMany(at => at.Flights)
                .WithRequired(f => f.AirplaneType)
                .HasForeignKey(f => f.AirplaneTypeId);
        }
    }
}