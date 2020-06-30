using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.News
{
    public class HeadHunterNewsMessage : INewsMessage
    {
        public string ObserverName { get => "HeadHunter"; }

        private string _message;
        public string Message { get => _message; set => _message = value; }

        public HeadHunterNewsMessage(string message)
        {
            _message = message;
        }
    }
}
