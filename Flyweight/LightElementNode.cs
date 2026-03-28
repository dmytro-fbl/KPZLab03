using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LightElementNode : LightNode
    {
        private TagMetaData _metaData;
        private List<LightNode> _children = new List<LightNode>();

        public LightElementNode(TagMetaData metaData)
        {
            _metaData = metaData;
        }

        public void Add(LightNode node) {  _children.Add(node); }

        public string InnerHtml
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in _children)
                {
                    sb.Append(child.OuterHtml);
                }
                return sb.ToString();
            }
        }

        public override string OuterHtml
        {
            get
            {
                
                if (_metaData.ClosingType == ClosingType.Single)
                {
                    return $"<{_metaData.TagName} />";
                }
                else
                {
                    return $"<{_metaData.TagName}>{InnerHtml}</{_metaData.TagName}>";
                }
            }
        }
    }
}
