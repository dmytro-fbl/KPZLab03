namespace Flyweight
{
    internal class Program
    {
        const string BookUrl = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("початок завантаження книги");

            string[] bookLines;

            try
            {
                using (var client = new HttpClient())
                {
                    string fullText = await client.GetStringAsync(BookUrl);
                    bookLines = fullText.Split(new[] { "\r", "\n", "\r\n" }, StringSplitOptions.None);
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Помилка завантаження: {ex.Message}");
                return;
            }

            Console.WriteLine($"Книгу завантажено. Кількість рядків: {bookLines.Length}\n");

            GC.Collect(); 
            GC.WaitForPendingFinalizers();
            long memoryBefore = GC.GetTotalMemory(true);

            TagFactory tagFactory = new TagFactory();

            
            TagMetaData divMeta = tagFactory.GetTagMeta("div");
            LightElementNode rootDiv = new LightElementNode(divMeta);

            Console.WriteLine("\nПочинаємо парсинг книги за правилами");

            for (int i = 0; i < bookLines.Length; i++)
            {
                string line = bookLines[i];
                if (string.IsNullOrWhiteSpace(line)) continue; 

                LightElementNode element = null;

                if (i == 0)
                {
                    element = new LightElementNode(tagFactory.GetTagMeta("h1"));
                }
                else if (line.Length < 20)
                {
                    element = new LightElementNode(tagFactory.GetTagMeta("h2"));
                }
                else if (line.StartsWith(" "))
                {
                    element = new LightElementNode(tagFactory.GetTagMeta("blockquote"));
                }
                else
                {
                    element = new LightElementNode(tagFactory.GetTagMeta("p"));
                }

                element.Add(new LightTextNode(line.Trim()));

                rootDiv.Add(element);
            }

            Console.WriteLine("Парсинг завершено\n");

            GC.Collect();
            GC.WaitForPendingFinalizers();
            long memoryAfter = GC.GetTotalMemory(true);

            long memoryUsed = memoryAfter - memoryBefore;
            Console.WriteLine("пам'ять");
            Console.WriteLine($"Пам'ять ДО: {memoryBefore / 1024.0 / 1024.0:F2} МБ");
            Console.WriteLine($"Пам'ять ПІСЛЯ: {memoryAfter / 1024.0 / 1024.0:F2} МБ");
            Console.WriteLine($"Використано під HTML-дерево: {memoryUsed / 1024.0:F1} КБ (або {memoryUsed / 1024.0 / 1024.0:F2} МБ)");

            Console.WriteLine("\nверстка 500 символів");
            string htmlOutput = rootDiv.OuterHtml;
            Console.WriteLine(htmlOutput.Substring(0, Math.Min(htmlOutput.Length, 500)));

            Console.ReadKey();
        }
    }
}
