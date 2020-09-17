using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Core
{
    public class ActivityObserver : IBlogObserver
    {
        public void Update(BlogPost post)
        {
            Console.WriteLine($"Notify Activity tracker: A new post: {post.Title} has been created at: {post.PostDate}");
        }
    }
}
