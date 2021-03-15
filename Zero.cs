using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle, IElectric
    // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }


        void ChargeBattery()
        {
            CurrentChargePercentage = 100.00;
            Console.WriteLine("Charging");
        }


        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"The {MainColor} Zero is a motorcycle");
        }
    }
}