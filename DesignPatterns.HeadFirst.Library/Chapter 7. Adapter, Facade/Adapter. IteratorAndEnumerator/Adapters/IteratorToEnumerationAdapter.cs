using DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._IteratorAndEnumerator.Data;

namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._IteratorAndEnumerator.Adapters
{
    public class IteratorToEnumerationAdapter<T> : IEnumeration<T>
    {
        public IteratorToEnumerationAdapter(IIterator<T> iterator)
        {
            _iterator = iterator;
        }

        private readonly IIterator<T> _iterator;

        public bool HasMoreElements()
        {
            return _iterator.HasNext();
        }

        public T NextElement()
        {
            return _iterator.Next();
        }
    }
}