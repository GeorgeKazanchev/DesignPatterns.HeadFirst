namespace DesignPatterns.HeadFirst.Library.Chapter_3._Decorator
{
    public abstract class Beverage
    {
        #region Properties

        public abstract decimal Cost { get; }

        public abstract string Description { get; }

        public Size Size { get; protected set; }

        #endregion

        #region Public methods

        public override string ToString()
        {
            return Description + " $" + Cost;
        }

        #endregion
    }
}