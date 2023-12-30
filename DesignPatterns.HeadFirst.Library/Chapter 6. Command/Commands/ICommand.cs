namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}