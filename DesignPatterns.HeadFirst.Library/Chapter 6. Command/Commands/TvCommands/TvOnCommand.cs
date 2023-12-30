using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class TvOnCommand : ICommand
    {
        public TvOnCommand(Tv tv)
        {
            Tv = tv;
        }

        public Tv Tv { get; private set; }

        public void Execute()
        {
            Tv.On();
        }

        public void Undo()
        {
            Tv.Off();
        }
    }
}