using DesignPatterns.HeadFirst.Library.Chapter_6._Command;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands;

namespace DesignPatterns.HeadFirst.App.Chapter_6._Command
{
    public class RemoteControlUndoTest
    {
        public static void Run()
        {
            Light livingRoomLight = new Light("Living Room");

            LightOnCommand livingRoomLightOn = new(livingRoomLight);
            LightOffCommand livingRoomLightOff = new(livingRoomLight);

            RemoteControl remoteControl = new(commandsCount: 7);
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            
            remoteControl.OnButton_OnClick(0);
            remoteControl.OffButton_OnClick(0);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.UndoButton_OnClick();
            remoteControl.OffButton_OnClick(0);
            remoteControl.OnButton_OnClick(0);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.UndoButton_OnClick();
        }
    }
}