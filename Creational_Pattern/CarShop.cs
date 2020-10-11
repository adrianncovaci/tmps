using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern
{
    public sealed class CarShop
    {
        private static readonly Lazy<CarShop> carShop = new Lazy<CarShop>(() => new CarShop(), true);
        private int carsSold;
        public static CarShop Instance { get { return carShop.Value; } }

        private CarShop()
        {
            carsSold = 0;
        }

        public ICar SellCar(string type)
        {
            carsSold++;
            return CarFactory.CreateCar(type);
        }

    }
}
