using SomeProject.Delegate;
using System;

namespace SomeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }
        static void AddReloadSpeed(Weapon weapon)
        {
            Console.WriteLine("Reload speed has been decreased");
        }
        static void UseDelegate()
        {
            var Forge = new WeaponForge();

            var upgrades = new WeaponUpgrades();

            Action<Weapon> upgradeHandler = upgrades.AddAim;
            upgradeHandler += upgrades.AddDamage;
            upgradeHandler += upgrades.AddExtraMag;

            upgradeHandler += AddReloadSpeed;

            Forge.Upgrade(upgradeHandler);
        }
    }
}
