using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class VectorRender : IRender
    {
        public void RenderShape(string shapeName)
        {
            Console.WriteLine("Drawing " + shapeName + " as lines");
        }

        
    }
}
