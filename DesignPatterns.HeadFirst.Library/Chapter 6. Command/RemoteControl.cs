using DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;
using System.Text;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command
{
    public class RemoteControl
    {
        public RemoteControl(uint commandsCount)
        {
            InitializeOnCommands(commandsCount, new NoCommand());
            InitializeOffCommands(commandsCount, new NoCommand());
            InitializeUndoCommand(new NoCommand());
        }

        public ICommand[] OnCommands { get; private set; }
        public ICommand[] OffCommands { get; private set; }
        public ICommand UndoCommand { get; private set; }

        public void SetCommand(uint slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButton_OnClick(uint slot)
        {
            OnCommands[slot].Execute();
            UndoCommand = OnCommands[slot];
        }

        public void OffButton_OnClick(uint slot)
        {
            OffCommands[slot].Execute();
            UndoCommand = OffCommands[slot];
        }

        public void UndoButton_OnClick()
        {
            UndoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("\n----- Remote Control -----\n");
            for (int i = 0; i < OnCommands.Length; ++i)
            {
                sb.Append($"[slot {i}] {OnCommands[i].GetType().Name}, {OffCommands[i].GetType().Name}\n");
            }

            sb.Append($"[undo] {UndoCommand.GetType().Name}");
            return sb.ToString();
        }

        private void InitializeOnCommands(uint commandsCount, ICommand onCommand)
        {
            OnCommands = new ICommand[commandsCount];
            for (int i = 0; i < commandsCount; ++i)
            {
                OnCommands[i] = onCommand;
            }
        }

        private void InitializeOffCommands(uint commandsCount, ICommand offCommand)
        {
            OffCommands = new ICommand[commandsCount];
            for (int i = 0; i < commandsCount; ++i)
            {
                OffCommands[i] = offCommand;
            }
        }

        private void InitializeUndoCommand(ICommand undoCommand)
        {
            UndoCommand = undoCommand;
        }
    }
}