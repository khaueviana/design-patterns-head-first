using KV.PatternCommand.Commands;
using KV.PatternCommand.Invocator;
using KV.PatternCommand.Receptor;

namespace KV.PatternCommand
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