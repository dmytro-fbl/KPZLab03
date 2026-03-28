using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sword : InventoryDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetStats() => _hero.GetStats() + ", Меч";

        public override int GetPower() => _hero.GetPower() + 5;
        
    }
}
