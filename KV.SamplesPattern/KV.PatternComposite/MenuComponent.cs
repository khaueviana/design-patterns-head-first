using System;

namespace KV.PatternComposite
{
    public abstract class MenuComponent
    {
        public abstract string GetName();

        public abstract string GetDescription();

        public abstract void Print();

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }
        
        public virtual decimal GetPrice()
        {
            return 0;
        }

        public virtual bool IsVegetarian()
        {
            return false;
        }
    }
}