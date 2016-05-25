namespace PatternObserver
{
    public interface Observer
    {
        void Update(double temp, double hum, double pressure);
    }
}