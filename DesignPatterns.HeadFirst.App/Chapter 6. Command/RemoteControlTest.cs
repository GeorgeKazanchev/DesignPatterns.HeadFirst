using DesignPatterns.HeadFirst.Library.Chapter_6._Command;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.App.Chapter_6._Command
{
    public class RemoteControlTest
    {
        public static void Run()
        {
            Light livingRoomLight = new("Living Room");
            Light kitchenLight = new("Kitchen");
            CeilingFan ceilingFan = new("Living Room");
            GarageDoor garageDoor = new("Main House");
            Stereo stereo = new("Living Room");

            LightOnCommand livingRoomLightOn = new(livingRoomLight);
            LightOffCommand livingRoomLightOff = new(livingRoomLight);
            LightOnCommand kitchenLightOn = new(kitchenLight);
            LightOffCommand kitchenLightOff = new(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new(garageDoor);
            GarageDoorDownCommand garageDoorDown = new(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new(stereo);
            StereoOffCommand stereoOff = new(stereo);

            RemoteControl remoteControl = new(commandsCount: 7);
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, garageDoorUp, garageDoorDown);

            Console.WriteLine(remoteControl.ToString());

            remoteControl.OnButton_OnClick(0);
            remoteControl.OffButton_OnClick(0);
            remoteControl.OnButton_OnClick(1);
            remoteControl.OffButton_OnClick(1);
            remoteControl.OnButton_OnClick(2);
            remoteControl.OffButton_OnClick(2);
            remoteControl.OnButton_OnClick(3);
            remoteControl.OffButton_OnClick(3);
        }
    }
}