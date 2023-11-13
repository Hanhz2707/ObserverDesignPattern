using ObserverDesignPattern.src.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.src.Observers
{
    public class StatisticsDisplay : IObservers
    {
        private float _temp;
        private float  _pressure;
        private float _humidity;
        private List<float> _tempList = new List<float>();

        public void update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _pressure = pressure;
            _humidity = humidity;
            _tempList.Add(_temp);
            display();
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature: " + Math.Round(_tempList.Average(),2) +"/"+ Math.Round(_tempList.Max(),2) +"/"+ Math.Round(_tempList.Min()));
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
