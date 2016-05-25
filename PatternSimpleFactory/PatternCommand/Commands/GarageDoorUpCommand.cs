using System;
using PatternCommand.Receptor;

namespace PatternCommand.Commands
{
    public class GarageDoorUpCommand : Command
    {
        private GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
        }

        public void Undo()
        {
            garageDoor.Down();
        }
    }
}