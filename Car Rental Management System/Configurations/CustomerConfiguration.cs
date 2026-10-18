using Car_Rental_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Rental_Management_System.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            // Primary key
            builder.HasKey(c => c.Id);

            // Full name
            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(100);

            // Email
            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasIndex(c => c.Email)
                .IsUnique();

            // Driving license
            builder.Property(c => c.DrivingLicenseNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(c => c.DrivingLicenseNumber)
                .IsUnique();

            builder.Property(c => c.LicenseExpiryDate)
                .IsRequired();

            // Soft delete
            builder.Property(c => c.IsActive)
                .IsRequired();

            // One Customer -> Many Rentals
            builder.HasMany(c => c.Rentals)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}