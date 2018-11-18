using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumAspMVC.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IQuestionRepository Questions { get; }
        ICommentRepository Comments { get; }
        int Complete();
    }
}