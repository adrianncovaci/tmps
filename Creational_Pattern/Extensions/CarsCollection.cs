using System.Collections;
using System.Collections.Generic;
using Abstract;
using Interfaces;

namespace Extensions
{
    public class CarsCollection : IteratorAggregate
    {
        List<ICar> cars = new List<ICar>();

        public List<ICar> GetItems()
        {
            return cars;
        }

        public void AddCar(ICar car)
        {
            cars.Add(car);
        }


        public override IEnumerator GetEnumerator()
        {
            return new IdIterator(this);
        }
    }
}