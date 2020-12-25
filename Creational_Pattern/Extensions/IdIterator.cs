using Abstract;

namespace Extensions
{
    public class IdIterator : Iterator
    {
        private CarsCollection cars;
        private int position = -1;

        public IdIterator(CarsCollection cars)
        {
            this.cars = cars;
        }
        public override object Current()
        {
            return this.cars.GetItems()[position];
        }

        public override int Key()
        {
            return this.position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this.position + 1;
            if (updatedPosition >= 0 && updatedPosition < this.cars.GetItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this.position = 0;
        }
    }
}