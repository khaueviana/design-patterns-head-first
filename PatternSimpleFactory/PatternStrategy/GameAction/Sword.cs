using System;

namespace PatternStrategy.GameAction
{
    public class Sword : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Manusear uma espada!");
        }
    }
}