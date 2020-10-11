using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern
{
    public class Sedan: ICar
    {
        public int Id { get; set; }
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
    }
}
