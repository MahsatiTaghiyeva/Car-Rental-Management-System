namespace Car_Rental_Management_System.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string DrivingLicenseNumber { get; set; } = null!;

        public DateTime LicenseExpiryDate { get; set; }

        public List<Rental> Rentals { get; set; } = new();

        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return $"Customer ID: {Id}, " +
                   $"Full Name: {FullName}, " +
                   $"Email: {Email}, " +
                   $"Driving License Number: {DrivingLicenseNumber}, " +
                   $"License Expiry Date: {LicenseExpiryDate:dd.MM.yyyy}, " +
                   $"Active: {IsActive}";
        }
    }
}