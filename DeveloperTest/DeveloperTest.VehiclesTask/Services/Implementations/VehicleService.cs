using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Services.Abstractions;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Services.Implementations
{
    public class VehicleService : IVehicleService
    {
        public IEnumerable<Vehicle> FindVehiclesByPartOfTypeName(string partOfName, IEnumerable<Vehicle> vehicles)
        {
            return vehicles.Where(vehicle => vehicle.GetType().Name.Contains(partOfName));
        }

        public IEnumerable<Vehicle> SortVehiclesByName(IEnumerable<Vehicle> vehicles)
        {
            return vehicles.OrderBy(vehicle => vehicle.GetType().Name);
        }

        public void PrintVehicles(IEnumerable<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetType().Name);
            }
        }
    }
}
