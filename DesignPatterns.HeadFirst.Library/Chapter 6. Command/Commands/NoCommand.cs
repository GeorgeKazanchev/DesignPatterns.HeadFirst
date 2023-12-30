namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() 
        {
            Console.WriteLine("This command doesn't do nothing.");
        }

        public void Undo()
        {
            Console.WriteLine("This command doesn't do nothing.");
        }
    }
}