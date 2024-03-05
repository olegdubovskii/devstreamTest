using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Vehicles.Models
{
    public class ElectricScooter : Vehicle
    {
        public short BatteryCapacity { get; set; }

        public ElectricScooter()
        {
            CreationYear = 2022;
            MaxSpeed = 20;
            Weight = 150.0;
            Color = "Green";
            BatteryCapacity = 800;
        }
    }
}
