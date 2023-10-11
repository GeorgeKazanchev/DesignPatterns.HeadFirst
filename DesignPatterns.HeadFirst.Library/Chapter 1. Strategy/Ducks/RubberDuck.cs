using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Ducks
{
    public class RubberDuck : Duck
    {
        #region Constructors

        public RubberDuck()
        {
            FlyBehaviour = new FlyNoWay();
            SoundBehaviour = new Squeak();
        }

        #endregion

        #region Public methods

        public override void Display()
        {
            Console.WriteLine("You see a rubber duck. The rubber duck can't see you.");
        }

        #endregion
    }
}