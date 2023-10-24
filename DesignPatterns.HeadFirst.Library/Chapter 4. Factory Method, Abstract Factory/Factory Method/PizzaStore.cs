namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaTypes pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaTypes pizza);
    }
}