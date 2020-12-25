using System.Collections;

namespace Abstract
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}