using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumAspMVC.Core
{
    public interface IForumContext
    {
        ForumContext GetForumContext();

    }
}