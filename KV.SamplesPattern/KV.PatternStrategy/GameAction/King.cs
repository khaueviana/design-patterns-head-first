namespace KV.PatternStrategy.GameAction
{
    public class King : Character
    {
        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}