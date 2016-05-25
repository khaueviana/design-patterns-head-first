using System.Text;
using PatternCommand.Commands;

namespace PatternCommand.Invocator
{
    public class RemoteControl
    {
        private Command[] onCommands;
        private Command[] offComands;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offComands = new Command[7];

            Command noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offComands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offComands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            offComands[slot].Execute();
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