using DesignPatterns.HeadFirst.Library.Chapter_6._Command;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands;
using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.App.Chapter_6._Command
{
    public class MacroCommandTest
    {
        public static void Run()
        {
            Light light = new("Living Room");
            Tv tv = new("Living Room");
            Stereo stereo = new("Living Room");
            Hottub hottub = new();

            LightOnCommand lightOn = new(light);
            LightOffCommand lightOff = new(light);
            StereoOnWithCdCommand stereoOn = new(stereo);
            StereoOffCommand stereoOff = new(stereo);
            TvOnCommand tvOn = new(tv);
            TvOffCommand tvOff = new(tv);
            HottubOnCommand hottubOn = new(hottub);
            HottubOffCommand hottubOff = new(hottub);

            ICommand[] partyOnCommands = {lightOn, stereoOn, tvOn, hottubOn};
            ICommand[] partyOffCommands = {lightOff, stereoOff, tvOff, hottubOff};

            MacroCommand partyOnMacro = new(partyOnCommands);
            MacroCommand partyOffMacro = new(partyOffCommands);

            RemoteControl remoteControl = new(commandsCount: 7);
            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl.ToString());
            Console.WriteLine("\n----- Pushing Macro On -----");
            remoteControl.OnButton_OnClick(0);
            Console.WriteLine("\n----- Pushing Macro Off -----");
            remoteControl.OffButton_OnClick(0);
        }
    }
}