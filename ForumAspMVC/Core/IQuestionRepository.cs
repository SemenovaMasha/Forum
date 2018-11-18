using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumAspMVC.Models;

namespace ForumAspMVC.Core
{
    public interface IQuestionRepository : IRepository<Question>
    {
    }
}