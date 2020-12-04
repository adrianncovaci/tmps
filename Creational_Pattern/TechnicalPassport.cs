using System;
using Interfaces;

namespace Creational_Pattern
{
    public class TechnicalPassport : ITechnicalRevision
    {
        public ICar car;
        public TechnicalPassport(ICar car)
        {
            this.car = car;
        }
        public void Revise()
        {
            if ((DateTime.Now - car.LastCheckDate).Days >= 365.25)
            {
                car.Revise();
            }
            else
            {
                Console.WriteLine(car.Id);
            }
        }

    }
}
