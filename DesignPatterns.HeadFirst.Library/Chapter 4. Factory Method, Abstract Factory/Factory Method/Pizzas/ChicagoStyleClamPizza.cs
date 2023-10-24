namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "The pizza has no name";
            Dough = "The Dough for Chicago Style Clam Pizza";
            Sauce = "The Sauce for Chicago Style Clam Pizza";
            Toppings = new List<string> { "There are so many toppings!" };
        }
    }
}