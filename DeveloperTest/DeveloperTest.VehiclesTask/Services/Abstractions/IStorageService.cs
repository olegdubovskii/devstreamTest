using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Services.Abstractions
{
    public interface IStorageService
    {
        void StoreInstances(IEnumerable<Vehicle> vehicles);
    }
}
