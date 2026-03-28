using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxi
{
    internal class SmartTextReaderLocker : ITextReader
    {
        private ITextReader _reader;
        private Regex _restrictedRegex;

        public SmartTextReaderLocker(ITextReader reader, string regexPattern)
        {
            _reader = reader;
            _restrictedRegex = new Regex(regexPattern); 
        }

        public char[][] ReadText(string filePath)
        {
            if (_restrictedRegex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null; 
            }

            return _reader.ReadText(filePath);
        }
    }
}
