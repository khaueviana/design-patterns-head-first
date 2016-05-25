using KV.PatternCommand.Receptor;

namespace KV.PatternCommand.Commands
{
    public class GarageDoorDownCommand : Command
    {
        private GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }

        public void Undo()
        {
            garageDoor.Up();
        }
    }
}