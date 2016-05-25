using System;

namespace PatternObserver
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private double temperature;
        private double humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
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
            Console.WriteLine("Forecast Display: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}