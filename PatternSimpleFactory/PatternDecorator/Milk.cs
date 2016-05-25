namespace PatternDecorator
{
    public class Milk : CondimentDecorator
    {
        private Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}