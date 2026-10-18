using Car_Rental_Management_System.Enums;

namespace Car_Rental_Management_System.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public int RentalId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public PaymentType PaymentType { get; set; }

        // Navigation property
        public Rental Rental { get; set; } = null!;

        public override string ToString()
        {
            return $"Payment ID: {Id}, " +
                   $"Rental ID: {RentalId}, " +
                   $"Amount: {Amount:F2}, " +
                   $"Payment Date: {PaymentDate:dd.MM.yyyy}, " +
                   $"Payment Type: {PaymentType}";
        }
    }
}