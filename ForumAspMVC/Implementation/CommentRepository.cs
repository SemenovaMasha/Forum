using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ForumAspMVC.Core;
using ForumAspMVC.Models;

namespace ForumAspMVC.Implementation
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(IForumContext context) : base(context)
        {
        }

        public IEnumerable<Comment> GetCommentsForQuestion(Question question)
        {
            return ForumContext.Comments.Where(c => c.Question.Id == question.Id).ToList();
        }

        public IEnumerable<Comment> GetCommentsForQuestion(Guid questionId)
        {
            return ForumContext.Comments.Where(c => c.Question.Id == questionId).ToList();
        }
        public ForumContext ForumContext
        {
            get { return Context as ForumContext; }
        }
    }
}