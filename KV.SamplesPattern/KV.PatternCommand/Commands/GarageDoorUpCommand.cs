using System;
using KV.PatternCommand.Receptor;

namespace KV.PatternCommand.Commands
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