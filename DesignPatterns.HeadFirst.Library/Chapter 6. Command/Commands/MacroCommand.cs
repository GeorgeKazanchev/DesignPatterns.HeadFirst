namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class MacroCommand : ICommand
    {
        public MacroCommand(ICommand[] commands)
        {
            Commands = commands;
        }

        public ICommand[] Commands { get; private set; }

        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach(var command in Commands)
            {
                command.Undo();
            }
        }
    }
}