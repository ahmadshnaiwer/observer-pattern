using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PostDate { get; set; }
    }
}
