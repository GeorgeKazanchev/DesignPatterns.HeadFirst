namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.Factory_Method
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "The pizza has no name";
            Dough = "The Dough for NY Style Veggie Pizza";
            Sauce = "The Sauce for NY Style Veggie Pizza";
            Toppings = new List<string> { "There are so many toppings!" };
        }
    }
}