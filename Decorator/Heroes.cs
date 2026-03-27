using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Warrior : IHero
    {
        public new string GetStats() => "Warrior";
        public new int GetPower() => 10;
    }

    public class Mage : IHero
    {
        public new string GetStats() => "Mage";
        public new int GetPower() => 20;
    }
    public class Palladin : IHero
    {
        public new string GetStats() => "Palladin";
        public new int GetPower() => 15;
    }
}
