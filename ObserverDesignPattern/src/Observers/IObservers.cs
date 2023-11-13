using ObserverDesignPattern.src.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.src.Observers
{
    public interface IObservers
    {
        public void update(float temp, float humidity, float pressure);
        public void display();
        public void unregister(ISubject subject);
        public void register(ISubject subject); 

    }
}
