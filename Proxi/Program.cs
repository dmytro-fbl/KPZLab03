namespace Proxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string safeFile = "document.txt";
            string secretFile = "passwords.secret";

            File.WriteAllText(safeFile, "Привіт!\nЦе тестовий файл.\nВін має три рядки.");
            File.WriteAllText(secretFile, "Супер секретні дані");

            ITextReader realReader = new SmartTextReader();

            Console.WriteLine(" ТЕСТ 1: Логування (SmartTextChecker)");
            ITextReader loggingProxy = new SmartTextChecker(realReader);

            char[][] textData = loggingProxy.ReadText(safeFile);


            Console.WriteLine("\nТЕСТ 2: Обмеження доступу (SmartTextReaderLocker)");

            ITextReader lockingProxy = new SmartTextReaderLocker(realReader, @"\.secret$");

            Console.WriteLine($"Спроба прочитати: {safeFile}");
            lockingProxy.ReadText(safeFile);

            Console.WriteLine($"Спроба прочитати: {secretFile}");
            lockingProxy.ReadText(secretFile);

            File.Delete(safeFile);
            File.Delete(secretFile);

            Console.ReadKey();
        }
    }
}
