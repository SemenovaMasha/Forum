using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumAspMVC.Core;
using ForumAspMVC.Models;

namespace ForumAspMVC.Implementation
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(IForumContext context)
            : base(context)
        {
        }

        public ForumContext ForumContext
        {
            get { return Context as ForumContext; }
        }
        
    }
}