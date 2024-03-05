using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesTask.Vehicles.Abstractions
{
    public abstract class Vehicle
    {
        public short CreationYear { get; set; }
        public short MaxSpeed { get; set; }
        public double Weight { get; set; }
        public string? Color { get; set; }
    }
}
