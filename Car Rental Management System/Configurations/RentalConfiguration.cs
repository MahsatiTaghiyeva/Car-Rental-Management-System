using Car_Rental_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Rental_Management_System.Data.Configurations
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rentals");

            // Primary key
            builder.HasKey(r => r.Id);

            // Foreign keys
            builder.Property(r => r.CarId)
                .IsRequired();

            builder.Property(r => r.CustomerId)
                .IsRequired();

            // Rental dates
            builder.Property(r => r.StartDate)
                .IsRequired();

            builder.Property(r => r.ExpectedReturnDate)
                .IsRequired();

            builder.Property(r => r.ActualReturnDate)
                .IsRequired(false);

            // Prices
            builder.Property(r => r.DailyPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(r => r.TotalPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            // Rental status
            builder.Property(r => r.Status)
                .IsRequired();

            // One Car -> Many Rentals
            builder.HasOne(r => r.Car)
                .WithMany(c => c.Rentals)
                .HasForeignKey(r => r.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            // One Customer -> Many Rentals
            builder.HasOne(r => r.Customer)
                .WithMany(c => c.Rentals)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // One Rental -> Many Payments
            builder.HasMany(r => r.Payments)
                .WithOne(p => p.Rental)
                .HasForeignKey(p => p.RentalId)
                .OnDelete(DeleteBehavior.Restrict);

            // One Rental -> Many Penalties
            builder.HasMany(r => r.Penalties)
                .WithOne(p => p.Rental)
                .HasForeignKey(p => p.RentalId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}