using System;

namespace KV.PatternStrategy.GameAction
{
    public class Axe : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cortar com um machado");
        }
    }
}