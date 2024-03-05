using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Vehicles.Models
{
    public class Car : Vehicle
    {
        public string? VINNumber { get; set; }
        public string? Brand { get; set; }
        public string? ModelName { get; set; }
        public double FuelCapacity { get; set; }
        public int Mileage { get; set; }

        public Car()
        {
            CreationYear = 2008;
            MaxSpeed = 220;
            Weight = 2200.0;
            Color = "Blue";
            VINNumber = "1HGBH41JXMN109186";
            Brand = "Volkswagen";
            ModelName = "Golf";
            FuelCapacity = 60.0;
            Mileage = 44786;
        }
    }
}
