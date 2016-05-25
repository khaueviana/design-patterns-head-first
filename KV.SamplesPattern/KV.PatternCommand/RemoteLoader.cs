using System;
using KV.PatternCommand.Commands;
using KV.PatternCommand.Invocator;
using KV.PatternCommand.Receptor;

namespace KV.PatternCommand
{
    public class RemoteLoader
    {
        public void Load()
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            Light light = new Light();
            TV tv = new TV();
            Hottub hottub = new Hottub();
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCd = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TVOnCommand tvOn = new TVOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(hottub);

            LightOffCommand lightOff = new LightOffCommand(light);
            TVOffCommand tvOff = new TVOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            Command[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            Command[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(4, stereoOnWithCd, stereoOff);
            remoteControl.SetCommand(5, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(6, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);

            for (int i = 0; i <= 6; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                remoteControl.OffButtonWasPushed(i);
                remoteControl.UndoButtonWasPushed();
            }
        }
    }
}