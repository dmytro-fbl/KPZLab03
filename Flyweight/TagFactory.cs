using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TagFactory
    {
        private Dictionary<string, TagMetaData> _tags = new Dictionary<string, TagMetaData>();

        public TagMetaData GetTagMeta(string tagName)
        {
            string key = tagName.ToLower();

            if (!_tags.ContainsKey(key))
            {
                switch (key)
                {
                    case "h1":
                    case "h2":
                    case "p":
                    case "blockquote":
                        _tags[key] = new TagMetaData(key, DisplayType.Block, ClosingType.Paired); 
                        break;
                    case "br":
                        _tags[key] = new TagMetaData(key, DisplayType.Block, ClosingType.Single);
                        break;
                    default:
                        _tags[key] = new TagMetaData(key, DisplayType.Inline, ClosingType.Paired);
                        break;
                }
                Console.WriteLine($"Створено новий шаблон для тегу: <{key}>");
            }
            return _tags[key];
        }
    }
}
