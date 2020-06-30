using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.News
{
    public interface IObserving
    {
        public void RegisterObserver(IObserver observer);

        public void RemoveObserver(IObserver observer);

        void NotifyObservers(INewsMessage NewsMessage);
    }
}
