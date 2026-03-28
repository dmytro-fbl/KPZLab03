using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Armor : InventoryDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetStats() => _hero.GetStats() + ", Накидка";

        public override int GetPower() => _hero.GetPower() + 7;
    }
}
