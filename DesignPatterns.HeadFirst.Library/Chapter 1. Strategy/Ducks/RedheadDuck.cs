using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Ducks
{
    public class RedheadDuck : Duck
    {
        #region Constructors

        public RedheadDuck()
        {
            FlyBehaviour = new FlyWithWings();
            SoundBehaviour = new Quack();
        }

        #endregion

        #region Public methods

        public override void Display()
        {
            Console.WriteLine("You see a redhead duck.");
        }

        #endregion
    }
}