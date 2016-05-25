namespace KV.PatternStrategy.GameAction
{
    public abstract class Character
    {
        protected WeaponBehavior weaponBehavior;

        public abstract void Fight();

        public void SetWeapon(WeaponBehavior wp)
        {
            weaponBehavior = wp;
        }
    }
}