using KV.PatternCommand.Commands;

namespace KV.PatternCommand.Invocator
{
    public class SimpleRemoteControl
    {
        private Command slot;

        public void SetCommand(Command command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}