using DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._IteratorAndEnumerator.Data;

namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._IteratorAndEnumerator.Adapters
{
    public class EnumerationToIteratorAdapter<T> : IIterator<T>
    {
        public EnumerationToIteratorAdapter(IEnumeration<T> enumeration)
        {
            _enumeration = enumeration;
        }

        private readonly IEnumeration<T> _enumeration;

        public bool HasNext()
        {
            return _enumeration.HasMoreElements();
        }

        public T Next()
        {
            return _enumeration.NextElement();
        }

        public void Remove(T item)
        {
            throw new InvalidOperationException("The interface does not support the remove operation.");
        }
    }
}