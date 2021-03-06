﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMVCForum.Models
{
    public class Topic
    {
        public int TopicID { get; set; }

        [Display(Name = "Title")]
        [Required]
        public string TopicName { get; set; }

        [Display(Name = "Created")]
        public DateTime DatePost { get; set; }

        public virtual ICollection<Post> Posts { get; set; }



        public virtual string AuthorTopicId { get; set; }

        [ForeignKey("AuthorTopicId")]
        public virtual ApplicationUser AuthorTopic { get; set; }
        public Topic()
        {
            DatePost = DateTime.Now;
        }
    }
}