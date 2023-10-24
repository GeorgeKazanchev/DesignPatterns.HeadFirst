namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            Name = "The pizza has no name";
            Dough = "The Dough for NY Style Pepperoni Pizza";
            Sauce = "The Sauce for NY Style Pepperoni Pizza";
            Toppings = new List<string> { "There are so many toppings!" };
        }
    }
}