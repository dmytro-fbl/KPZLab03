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
        //public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }

        public ILightNodeIterator GetDepthFirstIterator()
        {
            return new DepthFirstIterator(this);
        }
        public ILightNodeIterator GetBreadthFirstIterator()
        {
            return new BreadthFirstIterator(this);
        }

        public string Render()
        {
            OnCreated();
            OnClassListApplied();
            OnStylesApplied();
            string htmlOutput = GenerateHtml();

            OnTextRendered();

            return htmlOutput;
        }
        protected virtual void OnCreated() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnTextRendered() { }

        protected abstract string GenerateHtml();
    }
}
