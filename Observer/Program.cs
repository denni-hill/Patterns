using System;
using Observer.News;
using Observer.Observers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAgregator agregator = new NewsAgregator();

            new HeadHunterObserver(agregator);
            new TwitterObserver(agregator);
            new BBCObserver(agregator);

            agregator.NewsAvailable();
        }
    }
}
