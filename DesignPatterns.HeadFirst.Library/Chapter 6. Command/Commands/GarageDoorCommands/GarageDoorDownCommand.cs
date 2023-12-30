using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class GarageDoorDownCommand : ICommand
    {
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public GarageDoor GarageDoor { get; private set; }

        public void Execute()
        {
            GarageDoor.Down();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}