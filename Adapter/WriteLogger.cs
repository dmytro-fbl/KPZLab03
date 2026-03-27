using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adapter
{
    public class WriteLogger : Logger
    {
        private FileWriter _fireWriter;

        public WriteLogger(FileWriter fileWriter)
        {
            _fireWriter = fileWriter;
        }

        public override void Log(string text)
        {
            _fireWriter.Write();
            _fireWriter.WriteLine();
        }
        public override void Error(string text)
        {
            _fireWriter.Write();
            _fireWriter.WriteLine();
        }
        public override void Warn(string text)
        {
            _fireWriter.Write();
            _fireWriter.WriteLine();
        }
    }
}
