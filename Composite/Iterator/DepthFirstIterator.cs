using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterator
{
    public class DepthFirstIterator : ILightNodeIterator
    {
        private Stack<LightNode> _stack = new Stack<LightNode>();

        public DepthFirstIterator(LightNode root)
        {
            if(root != null)
            {
                _stack.Push(root);
            }
        }
        public bool HasNext()
        {
            return _stack.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext()) return null;

            LightNode current = _stack.Pop();

            if(current is LightElementNode element)
            {
                for(int i = element.Children.Count - 1; i >= 0; i--)
                {
                    _stack.Push(element.Children[i]);
                }
            }
            return current;
        }
    }
}
