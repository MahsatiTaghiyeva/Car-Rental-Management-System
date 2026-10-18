namespace Car_Rental_Management_System.Entities
{
    public class Penalty
    {
        public int Id { get; set; }

        public int RentalId { get; set; }

        public string Reason { get; set; } = null!;

        public decimal Amount { get; set; }

        public bool IsPaid { get; set; }

        public Rental Rental { get; set; } = null!;

        public override string ToString()
        {
            return $"Penalty ID: {Id}, " +
                   $"Rental ID: {RentalId}, " +
                   $"Reason: {Reason}, " +
                   $"Amount: {Amount:F2}, " +
                   $"Is Paid: {(IsPaid ? "Yes" : "No")}";
        }
    }
}