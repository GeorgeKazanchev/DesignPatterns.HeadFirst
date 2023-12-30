﻿using DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects;

namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.Commands
{
    public class CeilingFanLowSpeedCommand : CeilingFanSetSpeedCommand
    {
        public CeilingFanLowSpeedCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        protected override void SetSpeed()
        {
            CeilingFan.SetLowSpeed();
        }
    }
}