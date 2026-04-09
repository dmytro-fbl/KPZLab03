using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Command
{
    internal class AddNodeCommand : ICommand
    {
        private LightElementNode _parent;
        private LightNode _child;

        public AddNodeCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }
        public void Execute()
        {
            _parent.Add(_child);
        }

        public void Undo()
        {
            _parent.Remove(_child);
        }
    }
}
