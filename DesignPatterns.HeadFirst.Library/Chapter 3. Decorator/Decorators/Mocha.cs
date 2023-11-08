namespace DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Decorators
{
    public class Mocha : CondimentDecorator
    {
        #region Constructors

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        #endregion

        #region Properties

        public Beverage Beverage { get; set; }

        public override decimal Cost => GetCostBySize(Beverage.Size, _baseCost) + Beverage.Cost;

        public override string Description => Beverage.Description + ", Mocha";

        #endregion

        #region Private fields

        private readonly decimal _baseCost = 0.20m;

        #endregion
    }
}