namespace PatternStrategy.GameAction
{
    public class Queen : Character
    {
        public override void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}