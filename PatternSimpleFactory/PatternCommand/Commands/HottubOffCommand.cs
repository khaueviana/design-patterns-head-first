using PatternCommand.Receptor;

namespace PatternCommand.Commands
{
    public class HottubOffCommand : Command
    {
        private Hottub hottub;

        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            hottub.Off();
        }

        public void Undo()
        {
            hottub.On();
        }
    }
}