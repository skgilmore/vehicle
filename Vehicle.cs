using System;
using System.Collections.Generic;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Turn()
        {
            Console.WriteLine("The driver turns right.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Dont Cali Roll.. Stop!");
        }

        public virtual void Drive()
        {
            Console.WriteLine("------------------------");

        }
        public virtual void RefuelOrCharge()
        {
            // method definition omitted
        }

    }
}