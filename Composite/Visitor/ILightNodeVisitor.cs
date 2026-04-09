using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Visitor
{
    public interface ILightNodeVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode text);
    }
}
