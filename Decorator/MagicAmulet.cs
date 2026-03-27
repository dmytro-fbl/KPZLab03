using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MagicAmulet : InventoryDecorator
    {
        public MagicAmulet(IHero hero) : base(hero) { }

        public override string GetStats() => _hero.GetStats() + ", Камінь сонця";

        public override int GetPower() => _hero.GetPower() + 12;
    }
}
