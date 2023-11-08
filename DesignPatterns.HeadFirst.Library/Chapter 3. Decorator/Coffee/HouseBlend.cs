namespace DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Coffee
{
    public class HouseBlend : Beverage
    {
        #region Constructors

        public HouseBlend(Size size)
        {
            Description = "House Blend Coffee";
            Size = size;
        }

        #endregion

        #region Properties

        public override decimal Cost => 0.89m;

        public override string Description { get; }

        #endregion
    }
}