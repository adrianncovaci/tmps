using System;
using CarComponents;
using Hqs;
using Interfaces;

namespace CarTypes
{
    public class Sedan : ICar
    {
        public int Id { get; set; }
        public string SoftwareVersion { get; set; } = "1.0.0";
        public DateTime LastCheckDate { get; set; } = DateTime.Now;
        public BrakePedal brakePedal { get; set; } = new BrakePedal();
        public GasPedal gasPedal { get; set; } = new GasPedal();

        public Sedan(int id)
        {
            this.Id = id;
        }

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
            Console.WriteLine("Wait 2 seconds...");
            System.Threading.Thread.Sleep(2000);
            LastCheckDate = DateTime.Now;
            Console.WriteLine("Revised");
        }

        public void SoftwareUpdate(IHq hq)
        {
            this.SoftwareVersion = (hq as TeslaHq).LastSoftwareVersion;
        }

        public override string ToString()
        {
            return $"{this.Id} version {this.SoftwareVersion}";
        }
    }
}
