using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Iterator;

namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }

        public ILightNodeIterator GetDepthFirstIterator()
        {
            return new DepthFirstIterator(this);
        }
        public ILightNodeIterator GetBreadthFirstIterator()
        {
            return new BreadthFirstIterator(this);
        }
    }
}
