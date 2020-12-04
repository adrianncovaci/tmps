using System;
using System.Collections.Generic;
using System.Text;
using CarComponents;
using Interfaces;

namespace CarTypes
{
    public class Hatchback : ICar
    {
        public int Id { get; set; }
        public DateTime LastCheckDate { get; set; } = DateTime.Now;
        public BrakePedal brakePedal { get; set; } = new BrakePedal();
        public GasPedal gasPedal { get; set; } = new GasPedal();

        public void Honk()
        {
            Console.WriteLine("Hatchback Honk");
        }

        public object Clone()
        {
            var cloned = this.MemberwiseClone();
            return cloned;
        }

        public void Revise()
        {
            System.Threading.Thread.Sleep(1000);
            LastCheckDate = DateTime.Now;
            Console.WriteLine("Revised");
        }
    }
}
