using DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method;

namespace DesignPatterns.HeadFirst.App.Chapter_4._Factory_Method__Abstract_Factory
{
    public class PizzaStoreTest
    {
        public static void Run()
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza(PizzaTypes.Cheese);
            Console.WriteLine($"Ethan (the first customer) ordered a {pizza.Name}\n");

            pizza = chicagoPizzaStore.OrderPizza(PizzaTypes.Cheese);
            Console.WriteLine($"Joel (the second customer) ordered a {pizza.Name}\n");
        }
    }
}