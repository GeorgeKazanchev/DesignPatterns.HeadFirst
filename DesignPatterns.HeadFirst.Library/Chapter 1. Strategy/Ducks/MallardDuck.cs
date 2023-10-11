using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Ducks
{
    public class MallardDuck : Duck
    {
        #region Contructors

        public MallardDuck()
        {
            FlyBehaviour = new FlyWithWings();
            SoundBehaviour = new Quack();
        }

        #endregion

        #region Public methods

        public override void Display()
        {
            Console.WriteLine("You see a mallard duck.");
        }

        #endregion
    }
}