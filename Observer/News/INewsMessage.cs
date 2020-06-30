using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.News
{
    public interface INewsMessage
    {
        string ObserverName { get; }

        string Message { get; set; }
    }
}
