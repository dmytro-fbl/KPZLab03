using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    public class SmartTextChecker : ITextReader
    {
        private ITextReader _reader;
        public SmartTextChecker(ITextReader reader)
        {
            _reader = reader;
        }
        
        public char[][] ReadText(string filePath)
        {
            Console.WriteLine($"Відкритий файл: {filePath}");

            char[][] result = _reader.ReadText(filePath);

            Console.WriteLine($"файл успішно прочитано");

            int totalLines = result.Length;
            int totalChars = 0;
            foreach (var line in result)
            {
                totalChars += line.Length;
            }

            Console.WriteLine($" Загальна кількість рядків: {totalLines}");
            Console.WriteLine($" Загальна кількість символів: {totalChars}");
            Console.WriteLine($" Закриття файлу: {filePath}");
            

            return result;
        }
    }
}
