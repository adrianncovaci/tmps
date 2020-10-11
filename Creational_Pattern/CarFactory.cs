using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern
{
    class CarFactory
    {
        public static ICar CreateCar(string type)
        {
            if (type.Equals("sedan", StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Creating a sedan");
                return new Sedan();
            }
            if (type.Equals("hatchback", StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Creating a hatchback");
                return new Hatchback();
            }
            return null;
        }
    }
}
