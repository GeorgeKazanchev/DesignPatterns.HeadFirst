using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class HottubOffCommand : ICommand
    {
        public HottubOffCommand(Hottub hottub) 
        {
            Hottub = hottub;
        }

        public Hottub Hottub { get; private set; }

        public void Execute()
        {
            Hottub.Off();
        }

        public void Undo()
        {
            Hottub.On();
        }
    }
}