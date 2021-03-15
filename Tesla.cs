using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }


        void ChargeBattery()
        {
            // ChargeBattery();
            CurrentChargePercentage = 100.00;
            Console.WriteLine("Charging");
        }


        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"The {MainColor} Tesla is an electric car");

        }
        public override void Turn()
        {
            Console.WriteLine($"The Tessla only turns left to save on fuel");
            base.Drive();
            Console.WriteLine("--------The End----------------");

        }

    }
}