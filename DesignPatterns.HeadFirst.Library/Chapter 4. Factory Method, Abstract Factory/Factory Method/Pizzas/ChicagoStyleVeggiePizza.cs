namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "The pizza has no name";
            Dough = "The Dough for Chicago Style Veggie Pizza";
            Sauce = "The Sauce for Chicago Style Veggie Pizza";
            Toppings = new List<string> { "There are so many toppings!" };
        }
    }
}