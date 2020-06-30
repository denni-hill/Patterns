using Observer.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observers
{
    public class TwitterObserver : IObserver
    {
        public IObserving Observing { get; set; }

        public string Name { get => "Twitter"; }

        public TwitterObserver(IObserving observing)
        {
            observing.RegisterObserver(this);
        }

        public void Update(string newsMessage)
        {
            Console.WriteLine($"Twitter Observer got next news: {newsMessage}");
        }

        public void Unsubscribe()
        {
            Observing.RemoveObserver(this);
        }
    }
}
