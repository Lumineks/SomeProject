using SomeProject.Delegate;
using System;
namespace SomeProject
{
    public class WeaponUpgrades
    {
        public void AddAim(Weapon weapon)
        {
            Console.WriteLine("Aim has been added");
        }
        
        public void AddExtraMag(Weapon weapon)
        {
            Console.WriteLine("Extra mag has been added");
        }
        public void AddDamage(Weapon weapon)
        {
            Console.WriteLine("Extra damage has been added");
        }
    }
}
