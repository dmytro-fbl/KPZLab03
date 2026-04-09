using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;
using Composite.Visitor;
using Strategy.Strategy;

namespace Strategy
{
    public class LightImageNode : LightNode
    {
        private string _href;
        private IImageLoadStrategy _loadStrategy;

        public LightImageNode(string href)
        {
            _href = href;

            if(href.StartsWith("http://") || href.StartsWith("https://")){
                _loadStrategy = new NetworkLoadStrategy();
            }
            else
            {
                _loadStrategy= new FileSystemLoadStrategy();
            }
        }

        public void LoadImage()
        {
            _loadStrategy.Load(_href);
        }

        protected override string GenerateHtml()
        {
            return "";
        }

        public override void Accept(ILightNodeVisitor visitor)
        {
            
        }

        public override string InnerHtml => $"<img href=\"{_href}\" />";
    }
}
