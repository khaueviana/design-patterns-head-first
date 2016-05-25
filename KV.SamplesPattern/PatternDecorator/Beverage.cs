namespace PatternDecorator
{
    public abstract class Beverage
    {
        protected string description = "Bebida desconhecida";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}