using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Vehicles.Models
{
    public class Bicycle : Vehicle
    {
        public short WheelQuantity { get; set; }
        public string? FrameMaterial { get; set; }

        public Bicycle()
        {
            CreationYear = 2020;
            MaxSpeed = 40;
            Weight = 10.0;
            Color = "Black";
            WheelQuantity = 4;
            FrameMaterial = "Steel";
        }
    }
}
