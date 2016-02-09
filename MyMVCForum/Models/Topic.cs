using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCForum.Models
{
    public class Topic
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}