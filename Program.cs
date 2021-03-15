using System;
using System.Collections.Generic;

namespace Garage
{

    class Program
    {
        static void Main(string[] args)
        {


            Zero fxs = new Zero();
            // Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Tesla electric = new Tesla()
            {
                Name = "Fancy Tesla",
                BatteryKWh = 200.00,
                MainColor = "red",
                MaximumOccupancy = "4",
                CurrentChargePercentage = 15.0
            };
            Cessna sedan = new Cessna()
            {
                Name = "Cessna Sedan",
                MainColor = "green",
                MaximumOccupancy = "6",
                FuelCapacity = 18.50,
                CurrentTankPercentage = 25,
            };

            List<IElectric> electricVehicles = new List<IElectric>() {
                electric
            };

            Console.WriteLine("Electric Vehicles List:");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.Name}");
                Console.WriteLine($"Battery level before charge was at {ev.CurrentChargePercentage}%");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
                break;
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"After Charge: {ev.CurrentChargePercentage}%");
            }

            Console.WriteLine("/***********************************************/");

            // Ram ram = new Ram();
            // Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                sedan,
              };

            Console.WriteLine("Gas Vehicles List :");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.Name}");
                Console.WriteLine($"Should we fill up? Tank level:{gv.CurrentTankPercentage}%");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
                Console.WriteLine($"We got gas");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}

// Zero harley = new Zero()
// {
//     BatteryKWh = 100.00,
//     MainColor = "Silver",
//     MaximumOccupancy = "2"

// };

// Ram truck = new Ram()
// {
//     MainColor = "blue",
//     MaximumOccupancy = "3",
//     FuelCapacity = 10.0

// };
// harley.Drive();
// harley.Stop();
// harley.Turn();
// sedan.Drive();
// sedan.Turn();
// sedan.Stop();
// truck.Drive();
// truck.Stop();
// truck.Turn();
// electric.Drive();
// electric.Stop();
// electric.Turn();
//         }
//     }
// }