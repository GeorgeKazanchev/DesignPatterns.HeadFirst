using DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.AbstractFactory.Ingredients;

namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.AbstractFactory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }
    }
}