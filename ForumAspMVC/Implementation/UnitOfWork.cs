using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumAspMVC.Core;

namespace ForumAspMVC.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private ForumContext _context;
        public ForumContext ForumContext
        {
            get
            {
                //if (_context == null)
                //{
                //    _context = new ForumContext();
                //}
                return _context;
            }
        }

        //public UnitOfWork(ForumContext context)
        //{
        //    _context = context;
        //    Questions = new QuestionRepository(_context);
        //    Comments = new CommentRepository(_context);
        //}
        //public UnitOfWork()
        //{
        //    _context = new ForumContext();
        //    Questions = new QuestionRepository(_context);
        //    Comments = new CommentRepository(_context);
        //}
        public Guid id;
        public UnitOfWork(IForumContext context, IQuestionRepository Questions, ICommentRepository Comments)
        {
            id = Guid.NewGuid();
            //_context = new ForumContext();
            this.Questions = Questions;
            this._context = context.GetForumContext();
            this.Comments = Comments;
        }

        public IQuestionRepository Questions { get; private set; }
        public ICommentRepository Comments { get; private set; }

        public int Complete()
        {
            return ForumContext.SaveChanges();
        }

        public void Dispose()
        {
            ForumContext.Dispose();
        }
    }
}