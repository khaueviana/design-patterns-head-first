using System.Text;
using KV.PatternCommand.Commands;

namespace KV.PatternCommand.Invocator
{
    public class RemoteControlWithUndo
    {
        private Command[] onCommands;
        private Command[] offComands;
        private Command undoCommand;

        public RemoteControlWithUndo()
        {
            onCommands = new Command[7];
            offComands = new Command[7];

            Command noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offComands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offComands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offComands[slot].Execute();
            undoCommand = offComands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("\n------Remote Control------");

            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.AppendLine("[slot " + i + " [" + onCommands[i].GetType().Name + "  -  " + offComands[i].GetType().Name + "]");
            }

            return stringBuilder.ToString();
        }
    }
}