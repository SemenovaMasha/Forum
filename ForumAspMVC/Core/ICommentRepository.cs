using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumAspMVC.Models;

namespace ForumAspMVC.Core
{
    public interface ICommentRepository:IRepository<Comment>
    {
        IEnumerable<Comment> GetCommentsForQuestion(Question question);
        IEnumerable<Comment> GetCommentsForQuestion(Guid quenstionId);
    }
}