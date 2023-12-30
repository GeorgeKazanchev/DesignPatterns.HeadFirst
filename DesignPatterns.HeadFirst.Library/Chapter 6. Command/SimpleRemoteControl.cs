using DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command
{
    public class SimpleRemoteControl
    {
        public SimpleRemoteControl() { }

        public ICommand Slot { get; set; }

        public void SetCommand(ICommand command)
        {
            Slot = command;
        }

        public void Button_OnPressed()
        {
            Slot.Execute();
        }
    }
}