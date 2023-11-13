using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.src.Subject;

namespace ObserverDesignPattern.src.Observers
{
    public class ForecastDisplay : IObservers
    {
        private float _temp;
        private float _humidity;
        private float _pressure;

        public void update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            display();
        }
        public void display()
        {
            if (_temp > 80)
            {
                if (_humidity > 70)
                {
                    Console.WriteLine("Forecast: Watch out for rainny weather !");
                }
                else
                {
                    Console.WriteLine("Forecast: It is a hot sunny day !");
                }
            }
            else
            {
                if (_humidity > 70)
                {
                    Console.WriteLine("Forecast: Watch out for rainny weather !");
                }
                else
                {
                    Console.WriteLine("Forecast: Improving weather on the way !");
                }
            }
        }

        public void unregister(ISubject subject)
        {
            subject.removeObserver(this);
        }
        public void register(ISubject subject)
        {
            subject.addObserver(this);

        }
    }
}
