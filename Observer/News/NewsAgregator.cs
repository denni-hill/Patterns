using System;
using System.Collections.Generic;
using System.Text;
using Observer.Observers;

namespace Observer.News
{
    public class NewsAgregator : IObserving
    {
        private delegate void NewsAvailableDelegate(string NewsMessage);

        private Dictionary<string, NewsAvailableDelegate> NewsEvents = new Dictionary<string, NewsAvailableDelegate>();

        public void RegisterObserver(IObserver observer)
        {
            if(NewsEvents.ContainsKey(observer.Name))
            {
                NewsEvents[observer.Name] += observer.Update;
            }
            else NewsEvents.Add(observer.Name, observer.Update);
        }

        public void RemoveObserver(IObserver observer)
        {
            NewsEvents[observer.Name] -= observer.Update;
        }

        public void NotifyObservers(INewsMessage NewsMessage)
        {
            if(NewsEvents.ContainsKey(NewsMessage.ObserverName))
                NewsEvents[NewsMessage.ObserverName]?.Invoke(NewsMessage.Message);
        }

        public void NewsAvailable()
        {
            List<INewsMessage> News = new List<INewsMessage>()
            {
                GetHeadHunterNews(),
                GetTwitterNews(),
                GetBBCNews()
            };

            foreach(INewsMessage Message in News)
            {
                NotifyObservers(Message);
            }
        }

        private INewsMessage GetHeadHunterNews()
        {
            return new HeadHunterNewsMessage("It's a news from HH");
        }

        private INewsMessage GetTwitterNews()
        {
            return new TwitterNewsMessage("It's a news from twitter");
        }

        private INewsMessage GetBBCNews()
        {
            return new BBCNewsMessage("It's a news from BBC");
        }
    }
}
