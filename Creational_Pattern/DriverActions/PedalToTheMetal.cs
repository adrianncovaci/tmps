using System;
using Interfaces;

namespace DriverActions
{
    public class PedalToTheMetal
    {
        protected IPedal pedal;
        public PedalToTheMetal(IPedal pedal)
        {
            this.pedal = pedal;
        }
        public void HitIt()
        {
            pedal.Push();
        }
    }
}
