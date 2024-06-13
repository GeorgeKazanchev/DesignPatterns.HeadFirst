namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._IteratorAndEnumerator.Data
{
    public interface IEnumeration<T>
    {
        public bool HasMoreElements();
        public T NextElement();
    }
}