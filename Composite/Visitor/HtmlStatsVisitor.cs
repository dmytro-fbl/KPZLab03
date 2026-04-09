using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Visitor
{
    public class HtmlStatsVisitor : ILightNodeVisitor
    {
        public int ElementCount { get; private set; } = 0;
        public int TextNodeCount { get; private set; } = 0;

        public void Visit(LightElementNode element)
        {
            ElementCount++;
        }
        public void Visit(LightTextNode text)
        {
            TextNodeCount++;
        }

        public void PrintStatistics()
        {
            Console.WriteLine("АНАЛІЗ HTML СТОРІНКИ");
            Console.WriteLine($"Знайдено HTML-тегів: {ElementCount}");
            Console.WriteLine($"Знайдено текстових блоків: {TextNodeCount}");
            Console.WriteLine($"Загальна кількість вузлів: {ElementCount + TextNodeCount}");
        }
    }
}
