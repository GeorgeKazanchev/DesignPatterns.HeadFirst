namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "The pizza has no name";
            Dough = "The Dough for NY Style Clam Pizza";
            Sauce = "The Sauce for NY Style Clam Pizza";
            Toppings = new List<string> { "There are so many toppings!" };
        }
    }
}