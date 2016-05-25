namespace KV.PatternStrategy.GameAction
{
    public class Knight : Character
    {
        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}