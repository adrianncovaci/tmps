using System;
using Interfaces;

namespace CarComponents
{
    public class GasPedal : IPedal
    {

        public void Push()
        {
            System.Console.WriteLine("Vrum vrum");
        }
    }
}
