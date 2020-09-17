using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Core
{
    public interface IBlogNotifier
    {
        void Subscribe(IBlogObserver observer);
        void Unsubscribe(IBlogObserver observer);
        void Notify(BlogPost post);
    }
}
