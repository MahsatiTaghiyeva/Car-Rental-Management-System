using Car_Rental_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Rental_Management_System.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            // Primary key
            builder.HasKey(c => c.Id);

            // Properties
            builder.Property(c => c.Brand)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Model)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.PlateNumber)
                .IsRequired()
                .HasMaxLength(20);

            // Unique plate number
            builder.HasIndex(c => c.PlateNumber)
                .IsUnique();

            builder.Property(c => c.DailyPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(c => c.Year)
                .IsRequired();

            builder.Property(c => c.Mileage)
                .IsRequired();

            builder.Property(c => c.IsAvailable)
                .IsRequired();

            builder.Property(c => c.IsActive)
                .IsRequired();

            // One Car -> Many Rentals
            builder.HasMany(c => c.Rentals)
                .WithOne(r => r.Car)
                .HasForeignKey(r => r.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            // One Car -> Many Maintenance Records
            builder.HasMany(c => c.PenaltyMaintenanceRecords)
                .WithOne(m => m.Car)
                .HasForeignKey(m => m.CarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}