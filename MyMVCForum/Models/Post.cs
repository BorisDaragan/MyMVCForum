using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMVCForum.Models
{
    public class Post
    {
        public int PostID { get; set; }

        [Required]
        public string PostText { get; set; }
        public DateTime DateTopic { get; set; }


        [Required]
        public virtual int TopicRefID { get; set; }

        [ForeignKey("TopicRefID")]
        public virtual Topic Topic { get; set; }

        public virtual string AuthorPostId { get; set; }

        [ForeignKey("AuthorPostId")]
        public virtual ApplicationUser AuthorPost { get; set; }

        public Post()
        {
            DateTopic = DateTime.Now;
        }
    }
}