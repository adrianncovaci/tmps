using System.Collections.Generic;
using System.Linq;
using Interfaces;

namespace Hqs
{
    public class TeslaHq : IHq
    {
        public string LastSoftwareVersion { get; set; }
        private IList<ICar> CarsManufactured { get; set; }

        public TeslaHq()
        {
            LastSoftwareVersion = "1.0.0";
            CarsManufactured = new List<ICar>();
        }

        public void Attach(ICar car)
        {
            CarsManufactured.Add(car);
        }

        public void Detach(ICar car)
        {
            CarsManufactured.Remove(car);
        }

        public void NotifySoftwareUpdate()
        {
            foreach (var car in CarsManufactured)
            {
                car.SoftwareUpdate(this);
            }
        }

        public void MajorUpgrade()
        {
            var softwareNumbersList = this.LastSoftwareVersion.Split(".").Select(int.Parse).ToList();
            softwareNumbersList[0] += 1;
            this.LastSoftwareVersion = string.Join(".", softwareNumbersList);
        }

        public void MinorUpdate()
        {
            var softwareNumbersList = this.LastSoftwareVersion.Split(".").Select(int.Parse).ToList();
            softwareNumbersList[1] += 1;
            this.LastSoftwareVersion = string.Join(".", softwareNumbersList);
        }

        public void PatchUpdate()
        {
            var softwareNumbersList = this.LastSoftwareVersion.Split(".").Select(int.Parse).ToList();
            softwareNumbersList[2] += 1;
            this.LastSoftwareVersion = string.Join(".", softwareNumbersList);
        }
    }
}
