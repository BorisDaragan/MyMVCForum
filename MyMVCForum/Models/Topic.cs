using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCForum.Models
{
    public class Topic
    {
        public int TopicID { get; set; }

        [Required]
        public string TopicName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public DateTime DatePost { get; set; }

        public Topic()
        {
            DatePost = DateTime.Now;
        }
    }
}