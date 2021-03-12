using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }


        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"The {MainColor} Cessna zips by you");
        }
        public override void Stop()
        {
            Console.WriteLine($"The airplane lands gracefully and stops");
        }
    }
}