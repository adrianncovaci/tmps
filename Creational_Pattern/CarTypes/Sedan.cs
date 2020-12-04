using System;
using CarComponents;
using Interfaces;

namespace CarTypes
{
    public class Sedan : ICar
    {
        public int Id { get; set; }
        public DateTime LastCheckDate { get; set; } = DateTime.Now;
        public BrakePedal brakePedal { get; set; } = new BrakePedal();
        public GasPedal gasPedal { get; set; } = new GasPedal();
        public Sedan() { }

        public void Honk()
        {
            Console.WriteLine("Sedan Honk");
        }

        public object Clone()
        {
            var cloned = (Sedan)this.MemberwiseClone();
            return cloned;
        }

        public void Revise()
        {
            System.Threading.Thread.Sleep(2000);
            LastCheckDate = DateTime.Now;
            Console.WriteLine("Revised");
        }

        public void Push()
        {
            throw new NotImplementedException();
        }
    }
}
