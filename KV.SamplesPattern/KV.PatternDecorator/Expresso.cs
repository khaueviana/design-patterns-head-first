namespace KV.PatternDecorator
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}