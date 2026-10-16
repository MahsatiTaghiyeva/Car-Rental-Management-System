using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management_System.Entities
{
    internal class Penalty
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public string Reason { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }

        public string ToString()
        {
            return $"Penalty ID: {Id}, Rental ID: {RentalId}, Reason: {Reason}, Amount: {Amount:C}, Is Paid: {(IsPaid ? "Yes" : "No")}";
        }
    }
}
