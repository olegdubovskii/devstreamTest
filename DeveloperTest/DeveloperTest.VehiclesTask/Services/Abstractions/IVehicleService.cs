using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Services.Abstractions
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> SortVehiclesByName(IEnumerable<Vehicle> vehicles);
        IEnumerable<Vehicle> FindVehiclesByPartOfTypeName(string partOfName, IEnumerable<Vehicle> vehicles);
        void PrintVehicles(IEnumerable<Vehicle> vehicles);
    }
}
