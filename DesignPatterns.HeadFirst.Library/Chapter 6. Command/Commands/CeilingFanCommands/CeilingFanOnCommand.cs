using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public CeilingFan CeilingFan { get; private set; }

        public void Execute()
        {
            CeilingFan.On();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}