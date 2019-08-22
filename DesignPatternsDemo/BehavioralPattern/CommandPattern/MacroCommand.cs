using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public MacroCommand(List<ICommand> commands)
        {
            _commands = commands;
        }

        public string Execute()
        {
            return string.Join(", ", _commands.Select(c => c.Execute()).ToArray());
        }

        public string Undo()
        {
            return string.Join(", ", _commands.Select(c => c.Undo()).ToArray());
        }
    }
}