using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class CeilingFanHighSpeedCommand : CeilingFanSetSpeedCommand
    {
        public CeilingFanHighSpeedCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        protected override void SetSpeed()
        {
            CeilingFan.SetHighSpeed();
        }
    }
}