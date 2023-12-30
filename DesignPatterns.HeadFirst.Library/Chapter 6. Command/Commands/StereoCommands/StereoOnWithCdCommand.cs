using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class StereoOnWithCdCommand : ICommand
    {
        public StereoOnWithCdCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public Stereo Stereo { get; private set; }

        public void Execute()
        {
            Stereo.On();
            Stereo.SetCd();
            Stereo.SetVolume(11);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}