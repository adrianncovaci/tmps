using System;
using CarTypes;
using DriverActions;

namespace Creational_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sedan = new Sedan();
            var hatchback = new Hatchback();

            sedan.Id = 1;
            hatchback.Id = 2;

            var sedanPassport = new TechnicalPassport(sedan);
            var hatchbackPassport = new TechnicalPassport(hatchback);

            sedan.LastCheckDate = sedan.LastCheckDate.AddYears(-2);
            sedanPassport.Revise();

            var action1 = new PedalToTheMetal(sedan.brakePedal);
            action1.HitIt();
        }
    }
}
