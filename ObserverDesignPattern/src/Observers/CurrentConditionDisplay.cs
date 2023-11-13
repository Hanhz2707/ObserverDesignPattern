using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.src.Subject;

namespace ObserverDesignPattern.src.Observers
{
    public class CurrentConditionDisplay : IObservers
    {
        private float _temp;
        private float _pressure;
        private float _humidity;

        public void update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _pressure = pressure;
            _humidity = humidity;
            display();
        }
        public void display()
        {
            Console.WriteLine("Current Conditions: " + _temp.ToString() + " degrees and " + _humidity.ToString() + "% humidity " + _pressure.ToString() + " pressure");
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
