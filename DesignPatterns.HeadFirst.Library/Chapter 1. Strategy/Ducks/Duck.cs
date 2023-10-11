using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Ducks
{
    public abstract class Duck
    {
        #region Constructors

        public Duck()
        {
        }

        #endregion

        #region Properties

        public IFlyBehaviour FlyBehaviour { get; set; }

        public ISoundBehaviour SoundBehaviour { get; set; }

        #endregion

        #region Public methods

        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void PerformSound()
        {
            SoundBehaviour.MakeSound();
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            FlyBehaviour = flyBehaviour;
        }

        public void SetSoundBehaviour(ISoundBehaviour soundBehaviour)
        {
            SoundBehaviour = soundBehaviour;
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }

        public abstract void Display();

        #endregion
    }
}