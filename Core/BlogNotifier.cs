using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Core
{
    public class BlogNotifier : IBlogNotifier
    {
        private static List<IBlogObserver> observers;

        static BlogNotifier()
        {
            observers = new List<IBlogObserver>();
        }

        public void Subscribe(IBlogObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IBlogObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(BlogPost post)
        {
            foreach(IBlogObserver observer in observers)
            {
                observer.Update(post);
            }
        }
    }
}
