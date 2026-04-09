using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Visitor;

namespace Composite
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        protected override string GenerateHtml() => _text;
        public override string InnerHtml => _text;

        public override void Accept(ILightNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
