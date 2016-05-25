namespace KV.PatternAdapter
{
    public class TurkeyAdapter : Duck
    {
        private Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();    
            }
        }
    }
}