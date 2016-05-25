using System;

namespace KV.PatternObserver
{
    public class StatisticsDisplay : Observer,DisplayElement
    {
      private double temperature;
        private double humidity;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double hum, double pressure)
        {
            temperature = temp;
            humidity = hum;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Statistics diplay: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}
