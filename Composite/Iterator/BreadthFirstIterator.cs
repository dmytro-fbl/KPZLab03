using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterator
{
    public class BreadthFirstIterator : ILightNodeIterator
    {
        private Queue<LightNode> _queue = new Queue<LightNode>();

        public BreadthFirstIterator(LightNode root)
        {
            if(root != null)
            {
                _queue.Enqueue(root);
            }
        }
        public bool HasNext()
        {
            return _queue.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext()) return null;
            LightNode current = _queue.Dequeue();

            if(current is LightElementNode element)
            {
                foreach(var child in element.Children)
                {
                    _queue.Enqueue(child);
                }
            }

            return current;
        }
    }
}
