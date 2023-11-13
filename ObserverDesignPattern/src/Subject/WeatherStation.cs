using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.src.Observers;

namespace ObserverDesignPattern.src.Subject
{
    public class WeatherStation : ISubject
    {
        private List<IObservers> _observers = new List<IObservers>();
        private float _temp;
        private float _humidity;
        private float _pressure;

        public void addObserver(IObservers observer)
        {
            _observers.Add(observer);
            Console.WriteLine(observer + " is registered");
        }

        public void removeObserver(IObservers observer) 
        {
            _observers.Remove(observer);
            Console.WriteLine(observer + " is removed");
        }

        public void notifyObserver()
        {
            foreach(var observer in _observers) 
            {
                observer.update(_temp, _humidity, _pressure);
            }
        }

        public void setWeatherData(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            notifyObserver();
        }
    }
}
