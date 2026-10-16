using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management_System.Entities
{
    internal class PenaltyMaintenanceRecord
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime MaintenanceDate { get; set; }
        public decimal cost { get; set; }
        public DateTime NextMaintenanceDate { get; set; }

        public string ToString()
        {
            return $"Penalty Maintenance Record ID: {Id}, Car ID: {CarId}, Description: {Description}, Maintenance Date: {MaintenanceDate.ToShortDateString()}, Cost: {cost:C}, Next Maintenance Date: {NextMaintenanceDate.ToShortDateString()}";
        }
    }
}
