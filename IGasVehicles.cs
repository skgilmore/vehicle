using System;
using System.Collections.Generic;

namespace Garage
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
        // void ChargeBattery(int percent);
        double CurrentTankPercentage { get; set; }

        string Name { get; set; }


        void RefuelTank()
        {
            // ChargeBattery();
            CurrentTankPercentage = 100.00;
            Console.WriteLine("Fueling up...");
        }
        void Drive();

    }
}