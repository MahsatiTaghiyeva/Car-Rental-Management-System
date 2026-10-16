using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management_System.Entities
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string PlateNumber { get; set; } = null!;
        public decimal DailyPrice { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public bool IsAvailable { get; set; }
        public List<Rental> Rentals { get; set; } = new List<Rental>();
        public List<PenaltyMaintenanceRecord> PenaltyMaintenanceRecords { get; set; } = new List<PenaltyMaintenanceRecord>();
        public string ToString()
        {
            return $"Car ID: {Id}, Brand: {Brand}, Model: {Model}, Plate Number: {PlateNumber}, Daily Price: {DailyPrice:C}, Year: {Year}, Mileage: {Mileage} km, Available: {(IsAvailable ? "Yes" : "No")}";
        }
    }
}
