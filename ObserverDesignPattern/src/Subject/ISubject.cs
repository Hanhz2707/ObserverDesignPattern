using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.src.Observers;

namespace ObserverDesignPattern.src.Subject
{
    public interface ISubject
    {
        public void addObserver(IObservers observer);
        public void removeObserver(IObservers observer);
        public void notifyObserver();
    }
}
