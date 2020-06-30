using System;
using System.Collections.Generic;
using System.Text;
using Observer.News;

namespace Observer.Observers
{
    public interface IObserver
    {
        IObserving Observing { get; set; }

        string Name { get; }

        void Update(string newsMessage);

        void Unsubscribe();
    }
}
