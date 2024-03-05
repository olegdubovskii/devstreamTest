using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Services.Implementations;
using VehiclesTask.Vehicles.Abstractions;

namespace VehiclesTask
{
    public class Launcher
    {
        private InstanceService<Vehicle> _instanceService;
        public InstanceService<Vehicle> InstanceService
        {
            get
            {
                if (_instanceService is null)
                {
                    _instanceService = new InstanceService<Vehicle>();
                }
                return _instanceService;
            }
        }

        private VehicleService _vehicleService;
        public VehicleService VehicleService
        {
            get
            {
                if ( _vehicleService is null)
                {
                    _vehicleService = new VehicleService();
                }
                return _vehicleService;
            }
        }

        private StorageService _storageService;
        public StorageService StorageService
        {
            get
            {
                if(_storageService is null)
                {
                    _storageService = new StorageService();
                }
                return _storageService;
            }
        }

        public void LaunchApplication()
        {
            int commandNumber = 0;
            var vehicles = InstanceService.GetInstances();

            while (commandNumber != 4)
            {
                Console.WriteLine("Enter the command number:\n" +
                    "1.Pring alphabetically sorted Vehicle type names\n" +
                    "2.Find types by entered part of the name\n" +
                    "3.Write all instances of InstanceSerivce.GetInstances() to the disk\n" +
                    "4.Exit");
                commandNumber = Convert.ToInt32(Console.ReadLine());
                switch (commandNumber)
                {
                    case 1:
                        {
                            VehicleService.PrintVehicles(VehicleService.SortVehiclesByName(vehicles));
                            break;
                        }
                    case 2:
                        {
                            string? partOfName;
                            do
                            {
                                Console.WriteLine("Enter part of the name:");
                                partOfName = Console.ReadLine();
                            } while (string.IsNullOrEmpty(partOfName));

                            VehicleService.PrintVehicles(VehicleService.FindVehiclesByPartOfTypeName(partOfName, vehicles));
                            break;
                        }
                    case 3:
                        {
                            StorageService.StoreInstances(vehicles);
                            Console.WriteLine("Instances have stored");
                            break;
                        }
                    case 4:
                        {
                            commandNumber = 4;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Undefined command.");
                            break;
                        }
                }
            }
        }
    }
}
