using System;
using System.Collections.Generic;

namespace KV.PatternObserver
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            int i = observers.IndexOf(observer);

            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void NotifyObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetMeasurements(double t, double h, double p)
        {
            temperature = t;
            humidity = h;
            pressure = p;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }
    }
}