using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.State
{
    public interface INodeState
    {
        string Render(LightElementNode node);
        bool CanAddChild();
    }
}
