using System;
using System.Collections.Generic;

namespace Garage
{
    public interface IElectric
    {
        double BatteryKWh { get; set; }

        // void ChargeBattery(int percent);
        double CurrentChargePercentage { get; set; }
        string Name { get; set; }


        void ChargeBattery()
        {
            // ChargeBattery();
            CurrentChargePercentage = 100.00;
            Console.WriteLine("Charging please wait...");
        }
        void Drive();
    }
}