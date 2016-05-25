using System;

namespace PatternDecorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract String GetDescription();
    }
}