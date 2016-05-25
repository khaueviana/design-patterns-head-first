using PatternCommand.Commands;

namespace PatternCommand.Invocator
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