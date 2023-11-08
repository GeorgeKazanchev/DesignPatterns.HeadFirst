namespace DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Coffee
{
    public class DarkRoast : Beverage
    {
        #region Constructors

        public DarkRoast(Size size)
        {
            Description = "Dark Roast Coffee";
            Size = size;
        }

        #endregion

        #region Properties

        public override decimal Cost { get; }

        public override string Description { get; }

        #endregion
    }
}