using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public abstract class CeilingFanSetSpeedCommand : ICommand
    {
        public CeilingFanSetSpeedCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
            PreviousSpeed = ceilingFan.Speed;
        }

        public CeilingFan CeilingFan { get; private set; }
        public FanSpeed PreviousSpeed { get; private set; }

        public void Execute()
        {
            PreviousSpeed = CeilingFan.Speed;
            SetSpeed();
        }

        public void Undo()
        {
            switch (PreviousSpeed)
            {
                case FanSpeed.High:
                    CeilingFan.SetHighSpeed();
                    break;
                case FanSpeed.Medium:
                    CeilingFan.SetMediumSpeed();
                    break;
                case FanSpeed.Low:
                    CeilingFan.SetLowSpeed();
                    break;
            }
        }

        protected abstract void SetSpeed();
    }
}