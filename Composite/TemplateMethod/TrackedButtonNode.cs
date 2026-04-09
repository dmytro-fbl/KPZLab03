using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.TemplateMethod
{
    public class TrackedButtonNode : LightElementNode
    {
        public TrackedButtonNode() : base("button") { }

        protected override void OnCreated()
        {
            Console.WriteLine($" <{TagName}>: Елемент ініціалізовано.");
        }
        protected override void OnClassListApplied()
        {
            Console.WriteLine($" <{TagName}>: Класи підключено.");
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine($"<{TagName}>: HTML повністю згенеровано і готовий до виводу на екран.");
        }
    }
}
