using System;

namespace Creational_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShop chisinauShop = CarShop.Instance;
            var m5 = chisinauShop.SellCar("sedan");
            var a3 = chisinauShop.SellCar("hatchback");

            OtherCarShop cahulShop = OtherCarShop.instance;

            a3.Id = 1;
            var a3_2015 = (ICar)a3.Clone();
            a3_2015.Id = 2;

            Console.WriteLine(a3.Id);
            Console.WriteLine(a3_2015.Id);

            a3.Honk();
            a3_2015.Honk();
             
        }
    }
}
