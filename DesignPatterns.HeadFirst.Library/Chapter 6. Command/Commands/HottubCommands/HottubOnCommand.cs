using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class HottubOnCommand : ICommand
    {
        public HottubOnCommand(Hottub hottub)
        {
            Hottub = hottub;
        }

        public Hottub Hottub { get; private set; }

        public void Execute()
        {
            Hottub.On();
        }

        public void Undo()
        {
            Hottub.Off();
        }
    }
}