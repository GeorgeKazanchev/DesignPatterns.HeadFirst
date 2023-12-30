using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class StereoOffCommand : ICommand
    {
        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public Stereo Stereo { get; private set; }

        public void Execute()
        {
            Stereo.Off();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}