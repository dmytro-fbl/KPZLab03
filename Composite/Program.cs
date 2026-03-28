namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired, new List<string> { "container", "main-theme" });

            var h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Paired);
            h1.Add(new LightTextNode("Світла розмітка"));

            var ul = new LightElementNode("ul", DisplayType.Block, ClosingType.Paired, new List<string> { "list" });

            var li1 = new LightElementNode("li", DisplayType.Inline, ClosingType.Paired);
            li1.Add(new LightTextNode("Перший пункт"));

            var li2 = new LightElementNode("li", DisplayType.Inline, ClosingType.Paired);
            li2.Add(new LightTextNode("Другий пункт"));

            var li3 = new LightElementNode("li", DisplayType.Inline, ClosingType.Paired);
            li3.Add(new LightElementNode("br", DisplayType.Block, ClosingType.Single));
            li3.Add(new LightTextNode("Третій пункт з переносом"));

            ul.Add(li1);
            ul.Add(li2);
            ul.Add(li3);

            div.Add(h1);
            div.Add(ul);

            
            Console.WriteLine(" OUTER HTML головного елемента");
            Console.WriteLine(div.OuterHtml);

            Console.WriteLine("\nінформація про елемент");
            Console.WriteLine($"Кількість дочірніх елементів у <div>: {div.ChildCount}");
        }
    }
}
