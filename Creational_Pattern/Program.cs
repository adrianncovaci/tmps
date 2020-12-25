using System;
using CarTypes;
using DriverActions;
using Extensions;
using Hqs;

namespace Creational_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sedan = new Sedan(1);
            var hatchback = new Hatchback(2);

            var teslaHQ = new TeslaHq();
            teslaHQ.Attach(sedan);
            teslaHQ.Attach(hatchback);

            //2.0.0
            teslaHQ.MajorUpgrade();
            teslaHQ.NotifySoftwareUpdate();
            teslaHQ.Detach(hatchback);

            //2.0.1
            teslaHQ.PatchUpdate();
            teslaHQ.NotifySoftwareUpdate();

            System.Console.WriteLine(sedan.SoftwareVersion);
            System.Console.WriteLine(hatchback.SoftwareVersion);

            var cars = new CarsCollection();
            cars.AddCar(sedan);
            cars.AddCar(hatchback);

            foreach (var car in cars)
            {
                System.Console.WriteLine(car.ToString());
            }
        }
    }
}
