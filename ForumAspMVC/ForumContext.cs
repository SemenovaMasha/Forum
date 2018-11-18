using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ForumAspMVC.Models;

namespace ForumAspMVC
{
    public class ForumContext: DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ForumContext()
            : 
            base("DefaultConnection")
        {
        }
    }
    //public interface IForumContext
}