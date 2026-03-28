using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public enum DisplayType { Block, Inline }
    public enum ClosingType { Paired, Single }
    public class TagMetaData
    {
        public string TagName { get; }
        public DisplayType Display {  get; }
        public ClosingType ClosingType { get; }

        public TagMetaData(string tagName, DisplayType display, ClosingType closingType)
        {
            TagName = tagName;
            Display = display;
            ClosingType = closingType;
        }
    }
}
