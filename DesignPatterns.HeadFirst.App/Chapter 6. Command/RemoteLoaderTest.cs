using DesignPatterns.HeadFirst.Library.Chapter_6._Command;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.App.Chapter_6._Command
{
    public class RemoteLoaderTest
    {
        public static void Run()
        {
            CeilingFan ceilingFan = new CeilingFan("Living Room");

            CeilingFanMediumSpeedCommand ceilingFanMediumSpeed = new(ceilingFan);
            CeilingFanHighSpeedCommand ceilingFanHighSpeed = new(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

            RemoteControl remoteControl = new(commandsCount: 7);
            remoteControl.SetCommand(0, ceilingFanMediumSpeed, ceilingFanOff);
            remoteControl.SetCommand(1, ceilingFanHighSpeed, ceilingFanOff);

            remoteControl.OnButton_OnClick(0);
            remoteControl.OffButton_OnClick(0);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.UndoButton_OnClick();

            remoteControl.OnButton_OnClick(1);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.UndoButton_OnClick();
        }
    }
}
