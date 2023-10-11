using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Ducks
{
    public class JetPoweredDuck : Duck
    {
        #region Constructors

        public JetPoweredDuck()
        {
            FlyBehaviour = new JetPoweredFly();
            SoundBehaviour = new Quack();
        }

        #endregion

        #region Public methods

        public override void Display()
        {
            Console.WriteLine("You see a lot of fire in front of you.");
        }

        #endregion
    }
}