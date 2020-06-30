using Observer.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observers
{
    public class BBCObserver : IObserver
    {
        public string Name { get => "BBC"; }
        public IObserving Observing { get; set; }

        public BBCObserver(IObserving observing)
        {
            observing.RegisterObserver(this);
            Observing = observing;
        }

        public void Update(string newsMessage)
        {
            Console.WriteLine($"BBC Observer got next news: {newsMessage}");
        }

        public void Unsubscribe()
        {
            Observing.RemoveObserver(this);
        }
    }
}
