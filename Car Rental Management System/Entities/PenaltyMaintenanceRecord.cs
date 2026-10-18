namespace Car_Rental_Management_System.Entities
{
    public class PenaltyMaintenanceRecord
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public string Description { get; set; } = null!;

        public DateTime MaintenanceDate { get; set; }

        public decimal Cost { get; set; }

        public DateTime? NextMaintenanceDate { get; set; }

        public Car Car { get; set; } = null!;

        public override string ToString()
        {
            return $"Maintenance Record ID: {Id}, " +
                   $"Car ID: {CarId}, " +
                   $"Description: {Description}, " +
                   $"Maintenance Date: {MaintenanceDate:dd.MM.yyyy}, " +
                   $"Cost: {Cost:F2}, " +
                   $"Next Maintenance Date: " +
                   $"{(NextMaintenanceDate.HasValue ? NextMaintenanceDate.Value.ToString("dd.MM.yyyy") : "Not scheduled")}";
        }
    }
}