namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class LightOffCommand : ICommand
    {
        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public Light Light { get; private set; }

        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}