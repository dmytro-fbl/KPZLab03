using Composite.Command;
using Composite.State;
using Strategy;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            //Iterator
            /*

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
            */

            //Command

            /*
            CommandManager manager = new CommandManager();

            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
            var h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Paired);
            h1.Add(new LightTextNode("Головний заголовок"));

            var p = new LightElementNode("p", DisplayType.Block, ClosingType.Paired);
            p.Add(new LightTextNode("Якийсь текст"));

            Console.WriteLine("ДОДАЄМО ЕЛЕМЕНТИ");

            ICommand addH1 = new AddNodeCommand(div, h1);
            manager.ExecuteCommand(addH1);

            ICommand addP = new AddNodeCommand(div, p);
            manager.ExecuteCommand(addP);

            Console.WriteLine(div.OuterHtml);

            Console.WriteLine("\nКОРИСТУВАЧ НАТИСКАЄ Ctrl+Z");
            manager.Undo(); 

            Console.WriteLine(div.OuterHtml);

            */


            //State
            /*
            var button = new LightElementNode("button");
            button.Add(new LightTextNode("Натисни"));

            Console.WriteLine("Нормальний стан");
            Console.WriteLine(button.OuterHtml);


            Console.WriteLine("disabled стан");
            button.SetState(new DisabledState());
            button.Add(new LightTextNode("Цей текст не додасться"));
            Console.WriteLine(button.OuterHtml);

            Console.WriteLine("hidden стан");
            button.SetState(new HiddenState());
            Console.WriteLine($"Результат рендеру: '{button.OuterHtml}'");
            */
            Console.WriteLine("шаблонний метод");
            var container = new LightElementNode("div");

            var trackedButton = new TrackedButtonNode();
            trackedButton.Add(new LightTextNode("Підписатися"));

            container.Add(trackedButton);

            Console.WriteLine("Викликаємо метод Render()");
            string html = container.Render();

            Console.WriteLine("\nРЕЗУЛЬТАТ HTML");
            Console.WriteLine(html);

            Console.ReadKey();
        }
    }
}
