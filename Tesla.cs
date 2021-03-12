using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

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