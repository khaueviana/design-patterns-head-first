using PatternCommand.Receptor;

namespace PatternCommand.Commands
{
    public class HottubOnCommand : Command
    {
        private Hottub hottub;

        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            hottub.On();
        }

        public void Undo()
        {
            hottub.Off();
        }
    }
}