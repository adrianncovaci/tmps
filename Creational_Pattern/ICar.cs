using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern
{
    public interface ICar: ICloneable
    {
        public int Id { get; set; }
        public void Honk();
    }
}
