using PatternCommand.Commands;
using PatternCommand.Invocator;
using PatternCommand.Receptor;

namespace PatternCommand
{
    public class SimpleRemoteLoader
    {
        public void Load()
        {
            SimpleRemoteControl remoteControl = new SimpleRemoteControl();

            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            remoteControl.SetCommand(lightOn);
            remoteControl.ButtonWasPressed();

            GarageDoor garageDoor = new GarageDoor();
            GarageDoorUpCommand garageDoorOpenCommand = new GarageDoorUpCommand(garageDoor);

            remoteControl.SetCommand(garageDoorOpenCommand);
            remoteControl.ButtonWasPressed();
        }
    }
}