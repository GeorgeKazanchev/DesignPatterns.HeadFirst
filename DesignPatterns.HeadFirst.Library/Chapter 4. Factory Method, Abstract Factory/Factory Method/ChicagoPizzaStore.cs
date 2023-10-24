namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaTypes pizza)
        {
            switch (pizza)
            {
                case PizzaTypes.Cheese:
                    return new ChicagoStyleCheesePizza();
                case PizzaTypes.Veggie:
                    return new ChicagoStyleVeggiePizza();
                case PizzaTypes.Clam:
                    return new ChicagoStyleClamPizza();
                case PizzaTypes.Pepperoni:
                    return new ChicagoStylePepperoniPizza();
                default:
                    throw new Exception("We are sorry, there is no such a kind of pizza in our store.");
            }
        }
    }
}