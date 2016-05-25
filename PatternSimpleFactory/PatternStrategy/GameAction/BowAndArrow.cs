using System;

namespace PatternStrategy.GameAction
{
    public class BowAndArrow : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Atirar flecha!");
        }
    }
}