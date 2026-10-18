using Car_Rental_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Rental_Management_System.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");

            // Primary key
            builder.HasKey(p => p.Id);

            // Foreign key
            builder.Property(p => p.RentalId)
                .IsRequired();

            // Amount
            builder.Property(p => p.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            // Payment date
            builder.Property(p => p.PaymentDate)
                .IsRequired();

            // Payment type
            builder.Property(p => p.PaymentType)
                .IsRequired();

            // One Rental -> Many Payments
            builder.HasOne(p => p.Rental)
                .WithMany(r => r.Payments)
                .HasForeignKey(p => p.RentalId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}