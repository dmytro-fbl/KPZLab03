using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Command
{
    public class CommandManager
    {
        private Stack<ICommand> _history = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }
        public void Undo()
        {
            if(_history.Count > 0 )
            {
                ICommand lastCommand = _history.Pop();
                lastCommand.Undo();
                Console.WriteLine("Останню дію скасовано");
            }
            else
            {
                Console.WriteLine("Історія порожня, немає що відміняти");
            }
        }
    }
}
