using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class Shape
    {
        protected IRender render;

        public Shape(IRender render)
        {
            this.render = render;
        }

        public abstract void Draw();
    }
}
