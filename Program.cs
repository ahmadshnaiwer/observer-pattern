using ObserverPattern.Core;
using ObserverPattern.Models;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ModeratorObserver obs1 = new ModeratorObserver();
            ActivityObserver obs2 = new ActivityObserver();
            BlogNotifier notifier = new BlogNotifier();

            notifier.Subscribe(obs1);
            notifier.Subscribe(obs2);

            BlogPost post = new BlogPost();
            post.Id = 1;
            post.UserName = "Ahmad";
            post.Title = "Hellow World!";
            Console.WriteLine("Please enter blog post body:");
            post.Body = Console.ReadLine();
            post.PostDate = DateTime.Now;

            // logic to save the post

            notifier.Notify(post);
        }
    }
}
