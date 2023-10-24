namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaTypes pizza)
        {
            switch (pizza)
            {
                case PizzaTypes.Cheese:
                    return new NYStyleCheesePizza();
                case PizzaTypes.Veggie:
                    return new NYStyleVeggiePizza();
                case PizzaTypes.Clam:
                    return new NYStyleClamPizza();
                case PizzaTypes.Pepperoni:
                    return new NYStylePepperoniPizza();
                default:
                    throw new Exception("We are sorry, there is no such a kind of pizza in our store.");
            }
        }
    }
}