using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class InventoryDecorator : IHero
    {
        protected IHero _hero;
        
        public InventoryDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string GetStats() => _hero.GetStats();
        public virtual int GetPower() => _hero.GetPower();
        
    }
}
