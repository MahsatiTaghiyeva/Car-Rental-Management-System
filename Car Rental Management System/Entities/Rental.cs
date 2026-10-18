using Car_Rental_Management_System.Enums;

namespace Car_Rental_Management_System.Entities
{
    public class Rental
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        public int CustomerId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }

        public decimal DailyPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public Status Status { get; set; }

        // Navigation properties
        public Car Car { get; set; } = null!;
        public Customer Customer { get; set; } = null!;

        public List<Payment> Payments { get; set; } = new();

        public List<Penalty> Penalties { get; set; } = new();

        public override string ToString()
        {
            return $"Rental ID: {Id}, " +
                   $"Car ID: {CarId}, " +
                   $"Customer ID: {CustomerId}, " +
                   $"Start Date: {StartDate:dd.MM.yyyy}, " +
                   $"Expected Return Date: {ExpectedReturnDate:dd.MM.yyyy}, " +
                   $"Actual Return Date: {(ActualReturnDate.HasValue ? ActualReturnDate.Value.ToString("dd.MM.yyyy") : "Not Returned")}, " +
                   $"Daily Price: {DailyPrice:F2}, " +
                   $"Total Price: {TotalPrice:F2}, " +
                   $"Status: {Status}";
        }
    }
}