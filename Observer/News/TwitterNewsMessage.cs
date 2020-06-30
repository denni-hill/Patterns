using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.News
{
    public class TwitterNewsMessage : INewsMessage
    {
        public string ObserverName { get => "Twitter"; }

        private string _message;
        public string Message { get => _message; set => _message = value; }

        public TwitterNewsMessage(string message)
        {
            _message = message;
        }
    }
}
