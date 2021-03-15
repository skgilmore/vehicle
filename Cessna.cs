using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        // public List<Vehicle> gasVehicles { get; set; } = new List<Vehicle>();

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"The {MainColor} Cessna zips by you");
        }

        // public void RefuelTank(string refuel)
        // {
        //     RefuelTank.Add(refuel);
        // }

        public override void Stop()
        {
            Console.WriteLine($"The airplane lands gracefully and stops");
        }
    }
}