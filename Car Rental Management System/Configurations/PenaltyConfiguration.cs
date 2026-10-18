using Car_Rental_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Rental_Management_System.Data.Configurations
{
    public class PenaltyConfiguration : IEntityTypeConfiguration<Penalty>
    {
        public void Configure(EntityTypeBuilder<Penalty> builder)
        {
            builder.ToTable("Penalties");

            // Primary key
            builder.HasKey(p => p.Id);

            // Foreign key
            builder.Property(p => p.RentalId)
                .IsRequired();

            // Reason
            builder.Property(p => p.Reason)
                .IsRequired()
                .HasMaxLength(250);

            // Amount
            builder.Property(p => p.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            // Payment status
            builder.Property(p => p.IsPaid)
                .IsRequired();

            // One Rental -> Many Penalties
            builder.HasOne(p => p.Rental)
                .WithMany(r => r.Penalties)
                .HasForeignKey(p => p.RentalId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}