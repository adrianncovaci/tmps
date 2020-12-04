using System;
using Interfaces;

namespace CarComponents
{
    public class BrakePedal : IPedal
    {
        public void Push()
        {
            System.Console.WriteLine("Stop!");
        }
    }
}
