using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class TvOffCommand : ICommand
    {
        public TvOffCommand(Tv tv)
        {
            Tv = tv;
        }

        public Tv Tv { get; private set; }

        public void Execute()
        {
            Tv.Off();
        }

        public void Undo()
        {
            Tv.On();
        }
    }
}