using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.State
{
    public class NormalState : INodeState
    {
        public bool CanAddChild() => true;
        public string Render(LightElementNode node) => node.DefaultRender();
    }
    public class HiddenState : INodeState
    {
        public bool CanAddChild() => true;
        public string Render(LightElementNode node) => "";
    }
    public class DisabledState : INodeState
    {
        public bool CanAddChild()
        {
            Console.WriteLine("Вузол заблокований неможливо додати елемент");
            return false;
        }
        public string Render(LightElementNode node)
        {
            node.Attributes.Add("disabled=\"true\"");
            string output = node.DefaultRender();
            node.Attributes.Remove("disabled=\"true\""); 
            return output;
        }
    }
}
