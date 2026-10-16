using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental_Management_System.Enums;

namespace Car_Rental_Management_System.Entities
{
    internal class Payment
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentType PaymentType { get; set; }

        public string ToString()
        {
            return $"Payment ID: {Id}, Rental ID: {RentalId}, Amount: {Amount}, Payment Date: {PaymentDate.ToShortDateString()}, Payment Type: {PaymentType}";
        }
    }
}
