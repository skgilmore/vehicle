using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle
    // Electric motorcycle
    {
        public double BatteryKWh { get; set; }



        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"The {MainColor} Zero is a motorcycle");
        }
    }
}