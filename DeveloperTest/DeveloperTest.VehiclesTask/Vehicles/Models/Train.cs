using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Vehicles.Models
{
    public class Train : Vehicle
    {
        public short CarriageQuantity { get; set; }
        public double Length { get; set; }

        public Train()
        {
            CreationYear = 1990;
            MaxSpeed = 80;
            Weight = 50500;
            Color = "Grey";
            CarriageQuantity = 10;
            Length = 250.5;
        }
    }
}
