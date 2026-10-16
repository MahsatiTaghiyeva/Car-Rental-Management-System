using Car_Rental_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Brand)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.Model)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.PlateNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasIndex(c => c.PlateNumber)
            .IsUnique();

        builder.Property(c => c.DailyPrice)
            .HasPrecision(18, 2);

        builder.Property(c => c.IsAvailable)
            .IsRequired();

        // One Car -> Many Rentals
        builder.HasMany<Rental>()
            .WithOne()
            .HasForeignKey(r => r.CarId)
            .OnDelete(DeleteBehavior.Restrict);

        // One Car -> Many Maintenance Records
        builder.HasMany<PenaltyMaintenanceRecord>()
            .WithOne()
            .HasForeignKey(m => m.CarId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}