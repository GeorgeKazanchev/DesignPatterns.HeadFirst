namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._IteratorAndEnumerator.Data
{
    public interface IIterator<T>
    {
        public bool HasNext();
        public T Next();
        public void Remove(T item);
    }
}