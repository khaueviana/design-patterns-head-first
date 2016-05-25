namespace KV.PatternStrategy.GameAction
{
    public class Troll : Character
    {
        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}