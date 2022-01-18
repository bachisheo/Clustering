using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Objects;

namespace Clustering.src.Observer
{
    public class EventManager
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyAll(ClusteringResult result)
        {
            foreach (var obs in _observers)
            {
                obs.Update(result);
            }
        }
    }
}
