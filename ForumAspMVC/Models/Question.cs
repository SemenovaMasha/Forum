using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumAspMVC.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Text { get; set; }
        public DateTime Date { get; set; }

        public Question()
        {
            Id = Guid.NewGuid();
        }
    }
}