using System;
using System.Collections.Generic;
using System.Text;
using Observer.News;

namespace Observer.Observers
{
    public class HeadHunterObserver : IObserver
    {
        public IObserving Observing { get; set; }

        public string Name { get => "HeadHunter"; }

        public HeadHunterObserver(IObserving observing)
        {
            observing.RegisterObserver(this);
        }

        public void Update(string newsMessage)
        {
            Console.WriteLine($"HeadHunter Observer got next news: {newsMessage}");
        }

        public void Unsubscribe()
        {
            Observing.RemoveObserver(this);
        }
    }
}
