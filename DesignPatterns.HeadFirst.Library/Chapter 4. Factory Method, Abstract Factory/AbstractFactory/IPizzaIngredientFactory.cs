using DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.AbstractFactory.Ingredients;

namespace DesignPatterns.HeadFirst.Library.Chapter_4._Factory_Method__Abstract_Factory.AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public IClams CreateClams();
        public IVeggies[] CreateVeggies();
    }
}