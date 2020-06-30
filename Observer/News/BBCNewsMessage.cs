using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.News
{
    public class BBCNewsMessage : INewsMessage
    {
        public string ObserverName { get => "BBC"; }

        private string _message;
        public string Message { get => _message; set => _message = value; }

        public BBCNewsMessage(string message)
        {
            _message = message;
        }
    }
}
