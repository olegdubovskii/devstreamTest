using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VehiclesTask.Services.Abstractions;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask.Services.Implementations
{
    public class StorageService : IStorageService
    {
        public void StoreInstances(IEnumerable<Vehicle> vehicles)
        {
            using(FileStream fs = new FileStream("serializedInstances.json", FileMode.OpenOrCreate))
            {
                foreach(var vehicle in vehicles)
                {
                    JsonSerializer.Serialize(fs, vehicle);
                }
            }
        }
    }
}
