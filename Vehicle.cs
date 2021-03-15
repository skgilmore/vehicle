using System;
using System.Collections.Generic;

namespace Garage
{


    public class Vehicle
    {
        // public double BatteryKWh { get; set; }
        // public void ChargeBattery(double BatteryKWh)


        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public string Name { get; set; }
        public List<IGasVehicle> gasVehicles => throw new NotImplementedException();

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


    }
}