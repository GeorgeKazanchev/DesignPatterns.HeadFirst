namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class LightOnCommand : ICommand
    {
        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public Light Light { get; private set; }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}