using Strategy;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            var body = new LightElementNode("body", DisplayType.Block, ClosingType.Paired);

            var header = new LightElementNode("header", DisplayType.Block, ClosingType.Paired);
            header.Add(new LightTextNode("Це шапка сайту"));

            var main = new LightElementNode("main", DisplayType.Block, ClosingType.Paired);
            main.Add(new LightTextNode("Це основний контент"));

            var button = new LightElementNode("button", DisplayType.Inline, ClosingType.Paired);
            button.Add(new LightTextNode("Натисни мене"));
            main.Add(button);

            body.Add(header);
            body.Add(main);

            Console.WriteLine("OБХІД ВГЛИБ");
            var depthIterator = body.GetDepthFirstIterator();
            while (depthIterator.HasNext())
            {
                LightNode node = depthIterator.Next();
                if (node is LightElementNode element)
                    Console.WriteLine($"Вузол (Тег): <{element.TagName}>");
                else if (node is LightTextNode text)
                    Console.WriteLine($"Вузол (Текст): {text.OuterHtml}");
            }


            Console.WriteLine("ОБХІД ВШИР");
            var breadthIterator = body.GetBreadthFirstIterator();
            while (breadthIterator.HasNext())
            {
                LightNode node = breadthIterator.Next();
                if (node is LightElementNode element)
                    Console.WriteLine($"Вузол (Тег): <{element.TagName}>");
                else if (node is LightTextNode text)
                    Console.WriteLine($"Вузол (Текст): {text.OuterHtml}");
            }

            Console.ReadKey();
        }
    }
}
