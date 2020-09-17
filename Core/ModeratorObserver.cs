using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Core
{
    public class ModeratorObserver : IBlogObserver
    {
        public void Update(BlogPost post)
        {
            Console.WriteLine($"Notify Moderator: A new post: {post.Title} has been created at: {post.PostDate}");
        }
    }
}
