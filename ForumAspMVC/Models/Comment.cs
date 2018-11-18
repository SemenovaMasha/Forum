using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumAspMVC.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public Question Question { get; set; }
        public int QuestionId { get; set; }

        public Comment()
        {
            Id = Guid.NewGuid();
        }
    }
}