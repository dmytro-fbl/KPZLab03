using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileWriter
    {
        public void Write()
        {
            Console.Write("рядок");
        }
        public void WriteLine()
        {
            Console.WriteLine("З нового рядка");
        }
    }
}
