using System;

namespace KV.PatternStrategy.GameAction
{
    public class Sword : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Manusear uma espada!");
        }
    }
}