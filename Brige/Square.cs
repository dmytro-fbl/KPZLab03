using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Square : Shape
    {
        public Square(IRender render) : base(render)
        {
        }

        public override void Draw()
        {
            render.RenderShape("Square");
        }
    }
}
