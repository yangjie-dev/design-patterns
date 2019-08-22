using System.Collections.Generic;

namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class RemoteControl
    {
        private readonly List<ICommand> _onCommands;

        private readonly List<ICommand> _offCommands;

        private ICommand _undoCommand;

        public RemoteControl()
        {
            _offCommands = new List<ICommand> {new NoCommand(), new NoCommand(), new NoCommand()};

            _onCommands = new List<ICommand> {new NoCommand(), new NoCommand(), new NoCommand()};
            
            _undoCommand = new NoCommand();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;

            _offCommands[slot] = offCommand;
        }

        public string OnButtonWasPushed(int slot)
        {
            _undoCommand = _onCommands[slot];

            return _onCommands[slot].Execute();
        }

        public string OffButtonWasPushed(int slot)
        {
            _undoCommand = _offCommands[slot];
            
            return _offCommands[slot].Execute();
        }

        public string UndoButtonWasPushed()
        {
            return _undoCommand.Undo();
        }
    }
}