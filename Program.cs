using System;
using System.Collections.Generic;

namespace Garage
{

    class Program
    {
        static void Main(string[] args)
        {


            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            // fxs.Drive();
            // modelS.Drive();
            // mx410.Drive();


            Zero harley = new Zero()
            {
                BatteryKWh = 100.00,
                MainColor = "Silver",
                MaximumOccupancy = "2"

            };

            Tesla electric = new Tesla()
            {
                BatteryKWh = 200.00,
                MainColor = "red",
                MaximumOccupancy = "4"
            };
            Cessna sedan = new Cessna()
            {
                MainColor = "green",
                MaximumOccupancy = "6",
                FuelCapacity = 18.50
            };
            Ram truck = new Ram()
            {
                MainColor = "blue",
                MaximumOccupancy = "3",
                FuelCapacity = 10.0

            };
            harley.Drive();
            harley.Stop();
            harley.Turn();
            sedan.Drive();
            sedan.Turn();
            sedan.Stop();
            truck.Drive();
            truck.Stop();
            truck.Turn();
            electric.Drive();
            electric.Stop();
            electric.Turn();
        }
    }
}