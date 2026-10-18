using Car_Rental_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Rental_Management_System.Data.Configurations
{
    public class PenaltyMaintenanceRecordConfiguration
        : IEntityTypeConfiguration<PenaltyMaintenanceRecord>
    {
        public void Configure(
            EntityTypeBuilder<PenaltyMaintenanceRecord> builder)
        {
            builder.ToTable("MaintenanceRecords");

            // Primary key
            builder.HasKey(m => m.Id);

            // Foreign key
            builder.Property(m => m.CarId)
                .IsRequired();

            // Description
            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(500);

            // Maintenance date
            builder.Property(m => m.MaintenanceDate)
                .IsRequired();

            // Cost
            builder.Property(m => m.Cost)
                .HasPrecision(18, 2)
                .IsRequired();

            // Next maintenance date
            builder.Property(m => m.NextMaintenanceDate)
                .IsRequired();

            // One Car -> Many Maintenance Records
            builder.HasOne(m => m.Car)
                .WithMany(c => c.PenaltyMaintenanceRecords)
                .HasForeignKey(m => m.CarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}