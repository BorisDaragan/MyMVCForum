using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMVCForum.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string PostText { get; set; }

        public virtual int TopicRefID { get; set; }

        [ForeignKey("TopicRefID")]
        public virtual Topic Topic { get; set; }
        public DateTime DateTopic { get; set; }

        public Post()
        {
            DateTopic = DateTime.Now;
        }
    }
}