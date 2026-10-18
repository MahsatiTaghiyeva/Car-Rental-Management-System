namespace Car_Rental_Management_System.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string PlateNumber { get; set; } = null!;

        public decimal DailyPrice { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public bool IsAvailable { get; set; } = true;

        public bool IsActive { get; set; } = true;

        public List<Rental> Rentals { get; set; } = new();

        public List<PenaltyMaintenanceRecord> PenaltyMaintenanceRecords
        {
            get;
            set;
        } = new();

        public override string ToString()
        {
            return $"Car ID: {Id}, " +
                   $"Brand: {Brand}, " +
                   $"Model: {Model}, " +
                   $"Plate Number: {PlateNumber}, " +
                   $"Daily Price: {DailyPrice:F2}, " +
                   $"Year: {Year}, " +
                   $"Mileage: {Mileage} km, " +
                   $"Available: {(IsAvailable ? "Yes" : "No")}, " +
                   $"Active: {IsActive}";
        }
    }
}