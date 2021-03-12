using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"The {MainColor} Ram is a big ole truck");
        }
        public override void Stop()
        {
            Console.WriteLine($"The ram never never stops");
        }

    }

}