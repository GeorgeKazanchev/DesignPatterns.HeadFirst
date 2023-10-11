using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Ducks
{
    public class DecoyDuck : Duck
    {
        #region Constructors

        public DecoyDuck()
        {
            FlyBehaviour = new FlyNoWay();
            SoundBehaviour = new MuteQuack();
        }

        #endregion

        #region Public methods

        public override void Display()
        {
            Console.WriteLine("You see a trap.");
        }

        #endregion
    }
}