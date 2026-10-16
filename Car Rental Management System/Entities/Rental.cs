using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental_Management_System.Enums;

namespace Car_Rental_Management_System.Entities
{
    internal class Rental
    {
        public int Id { get; set; } 
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; } // Nullable to handle cases where the car hasn't been returned yet
        public decimal DailyPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Status Status { get; set; }  // e.g., "Ongoing", "Completed", "Overdue"
        public List<Payment> Payments { get; set; } = new List<Payment>();
        public List<PenaltyMaintenanceRecord> PenaltyMaintenanceRecords { get; set; } = new List<PenaltyMaintenanceRecord>();
        public string ToString()
        {
            return $"Rental ID: {Id}, Car ID: {CardId}, Customer ID: {CustomerId}, Start Date: {StartDate.ToShortDateString()}, Expected Return Date: {ExpectedReturnDate.ToShortDateString()}, Actual Return Date: {(ActualReturnDate.HasValue ? ActualReturnDate.Value.ToShortDateString() : "Not Returned")}, Daily Price: {DailyPrice:C}, Total Price: {TotalPrice:C}, Status: {Status}";
        }
    }
}
