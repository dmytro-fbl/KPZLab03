using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Composite.State;

namespace Composite
{
    public enum DisplayType { Block, Inline }
    public enum ClosingType { Paired, Single }
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display {  get; set; }
        public ClosingType ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; } = new List<LightNode>();
        public List<string> Attributes { get; set; } = new List<string>();

        private INodeState _state = new NormalState();

        
        public int ChildCount => Children.Count;

        public LightElementNode(string tagName, DisplayType display, ClosingType closing, List<string> cssClasses = null)
        {
            TagName = tagName;
            Display = display;
            ClosingType = closing;
            CssClasses = cssClasses ?? new List<string>();
            Children = new List<LightNode>();
        }
        public LightElementNode(string tagName)
        {
            TagName = tagName;
        }

        public void SetState(INodeState state) => _state = state;
        public void Add(LightNode node)
        {
            if (_state.CanAddChild())
            {
                Children.Add(node);
            }
        }


        public void Remove(LightNode node) => Children.Remove(node);

        public string DefaultRender()
        {
            string attrs = Attributes.Count > 0 ? " " + string.Join(" ", Attributes) : "";
            string inner = "";
            foreach (var child in Children) inner += child.OuterHtml;
            return $"<{TagName}{attrs}>{inner}</{TagName}>";
        }
        public override string InnerHtml => "";
        

        public override string OuterHtml => _state.Render(this);
        
    }
}
