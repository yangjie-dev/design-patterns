using System.Collections.Generic;
using DesignPatternsDemo.BehavioralPattern.CommandPattern;
using Xunit;

namespace DesignPatternsDemoTests.BehavioralPattern
{
    public class CommandPatternTests
    {
        [Fact]
        public void ShouldOnOffLightByCommand()
        {
            //Arrange
            var remoteControl = new RemoteControl();

            var light = new Light();

            var lightOnCommand = new LightOnCommand(light);

            var lightOffCommand = new LightOffCommand(light);

            remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);

            //Assert
            Assert.Equal("light on", remoteControl.OnButtonWasPushed(0));

            Assert.Equal("light off", remoteControl.OffButtonWasPushed(0));

            Assert.Equal(null, remoteControl.OnButtonWasPushed(1));

            Assert.Equal(null, remoteControl.OffButtonWasPushed(1));
        }

        [Fact]
        public void ShouldUndoLightByPrevCommand()
        {
            //Arrange
            var light = new Light();

            var lightOnCommand = new LightOnCommand(light);

            var lightOffCommand = new LightOffCommand(light);

            var remoteControl = new RemoteControl();

            remoteControl.SetCommand(1, lightOnCommand, lightOffCommand);

            //Assert
            Assert.Equal("light on", remoteControl.OnButtonWasPushed(1));

            Assert.Equal("light off", remoteControl.UndoButtonWasPushed());
        }

        [Fact]
        void ShouldUndoFanByPrevCommonStatus()
        {
            //Arrange
            var remoteControl = new RemoteControl();

            var fan = new Fan();

            var fanHighCommand = new FanHighCommand(fan);

            var fanOffCommand = new FanOffCommand(fan);

            remoteControl.SetCommand(2, fanHighCommand, fanOffCommand);

            //Assert
            Assert.Equal("fan high", remoteControl.OnButtonWasPushed(2));
            Assert.Equal("fan off", remoteControl.OffButtonWasPushed(2));
            Assert.Equal("fan high", remoteControl.UndoButtonWasPushed());
        }

        [Fact]
        void ShouldUseMacroCommand()
        {
            //Arrange
            var fan = new Fan();

            var fanHighCommand = new FanHighCommand(fan);

            var fanOffCommand = new FanOffCommand(fan);

            var light = new Light();

            var lightOnCommand = new LightOnCommand(light);

            var lightOffCommand = new LightOffCommand(light);

            var partyOn = new List<ICommand> {lightOnCommand, fanHighCommand};
            
            var partyOff = new List<ICommand>{lightOffCommand, fanOffCommand};
            
            var partyOnMacro = new MacroCommand(partyOn);
            
            var partyOffMacro = new MacroCommand(partyOff);
            
            var remoteControl = new RemoteControl();

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            //Assert
            Assert.Equal("light on, fan high", remoteControl.OnButtonWasPushed(0));
            Assert.Equal("light off, fan off", remoteControl.OffButtonWasPushed(0));
            Assert.Equal("light on, fan high", remoteControl.UndoButtonWasPushed());
        }
    }
}