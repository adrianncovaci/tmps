using System;
using System.Collections.Generic;
using System.Text;
using CarComponents;

namespace Interfaces
{
    public interface ICar : ICloneable, ITechnicalRevision
    {
        int Id { get; set; }

        DateTime LastCheckDate { get; set; }
        BrakePedal brakePedal { get; set; }
        GasPedal gasPedal { get; set; }
        void Honk();
    }
}
