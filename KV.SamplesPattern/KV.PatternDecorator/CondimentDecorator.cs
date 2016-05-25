using System;

namespace KV.PatternDecorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract String GetDescription();
    }
}