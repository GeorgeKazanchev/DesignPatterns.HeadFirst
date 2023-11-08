namespace DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Coffee
{
    public class Espresso : Beverage
    {
        #region Constructors

        public Espresso(Size size)
        {
            Description = "Espresso";
            Size = size;
        }

        #endregion

        #region Properties

        public override decimal Cost => 1.99m;

        public override string Description { get; }

        #endregion
    }
}