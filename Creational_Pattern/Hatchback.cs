using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern
{
    public class Hatchback: ICar
    {
        public int Id { get; set; }
        public Hatchback() { }

        public void Honk()
        {
            Console.WriteLine("Hatchback Honk");
        }

        public object Clone()
        {
            var cloned = this.MemberwiseClone();
            return cloned;
        }
    }
}
