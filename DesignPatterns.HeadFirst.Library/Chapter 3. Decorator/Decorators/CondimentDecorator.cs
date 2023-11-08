namespace DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        #region Properties

        public override abstract string Description { get; }

        #endregion

        #region Public methods

        public virtual decimal GetCostBySize(Size size, decimal baseCost)
        {
            return size switch
            {
                Size.Tall => baseCost * 2.0m,
                Size.Grande => baseCost * 1.5m,
                Size.Venti => baseCost * 1.0m,
                _ => throw new NotImplementedException(),
            };
        }

        #endregion
    }
}