using DesignPatterns.HeadFirst.Library.Chapter_6._Command;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.App.Chapter_6._Command
{
    public class SimpleRemoteControlTest
    {
        public static void Run()
        {
            SimpleRemoteControl remoteControl = new();
            Light light = new("Kitchen");
            GarageDoor garageDoor = new("Main House");
            LightOnCommand lightOnCommand = new(light);
            GarageDoorUpCommand doorOpenCommand = new(garageDoor);

            remoteControl.SetCommand(lightOnCommand);
            remoteControl.Button_OnPressed();
            remoteControl.SetCommand(doorOpenCommand);
            remoteControl.Button_OnPressed();
        }
    }
}