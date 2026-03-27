using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Triangle : Shape
    {
        public Triangle(IRender render) : base(render)
        {
        }

        public override void Draw()
        {
            render.RenderShape("Triangle");
        }
    }
}
