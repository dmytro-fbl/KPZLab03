using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    public interface ITextReader
    {
        char[][] ReadText(string filePath);
    }
}
