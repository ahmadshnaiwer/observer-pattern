using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Core
{
    public interface IBlogObserver
    {
        void Update(BlogPost post);
    }
}
