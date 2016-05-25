using System;

namespace KV.PatternStrategy.GameAction
{
    public class BowAndArrow : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Atirar flecha!");
        }
    }
}