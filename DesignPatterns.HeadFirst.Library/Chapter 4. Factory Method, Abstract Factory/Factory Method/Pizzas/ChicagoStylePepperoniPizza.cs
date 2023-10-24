namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "The pizza has no name";
            Dough = "The Dough for Chicago Style Pepperoni Pizza";
            Sauce = "The Sauce for Chicago Style Pepperoni Pizza";
            Toppings = new List<string> { "There are so many toppings!" };
        }
    }
}