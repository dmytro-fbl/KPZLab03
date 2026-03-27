namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHero myHero = new Mage();

            myHero = new Sword(myHero);

            myHero = new Sword(myHero);

            myHero = new MagicAmulet(myHero);

            Console.WriteLine("Склад героя: " + myHero.GetStats());
            Console.WriteLine("Загальна сила: " + myHero.GetPower());

            IHero warrior = new Warrior();

            Console.WriteLine(warrior.GetStats());
            Console.WriteLine(warrior.GetPower());  

            warrior = new Sword(warrior);
            warrior = new Armor(warrior);
            Console.WriteLine("Склад героя: " + warrior.GetStats());
            Console.WriteLine("Загальна сила: " + warrior.GetPower());
        }
    }
}
