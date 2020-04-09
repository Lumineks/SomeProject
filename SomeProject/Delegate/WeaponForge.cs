using SomeProject.Delegate;
using System;
namespace SomeProject
{
    public class WeaponForge
    {
        

        public void Upgrade(Action<Weapon> upgradeHandler)
        {
            var weapon = Weapon.Create();

            upgradeHandler(weapon);
        }
    }
}
