using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Entities.Car> Cars { get; set; }
        public DbSet<Entities.Customer> Customers { get; set; }
        public DbSet<Entities.Rental> Rentals { get; set; }
        public DbSet<Entities.Payment> Payments { get; set; }
        public DbSet<Entities.PenaltyMaintenanceRecord> PenaltyMaintenanceRecords { get; set; }
        public DbSet<Entities.Penalty> Penalties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );
        }
    }
}
