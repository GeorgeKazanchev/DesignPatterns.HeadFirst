using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public GarageDoor GarageDoor { get; private set; }

        public void Execute()
        {
            GarageDoor.Up();
        }

        public void Undo()
        {

        }
    }
}