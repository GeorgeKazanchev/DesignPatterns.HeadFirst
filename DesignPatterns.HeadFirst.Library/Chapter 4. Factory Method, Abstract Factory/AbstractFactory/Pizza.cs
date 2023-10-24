using DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.AbstractFactory.Ingredients;

namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public ICheese Cheese { get; set; }
        public IClams Clams { get; set; }
        public IVeggies[] Veggies { get; set; }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}