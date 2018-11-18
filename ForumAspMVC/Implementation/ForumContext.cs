using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumAspMVC.Core;

namespace ForumAspMVC.Implementation
{
    public class ForumDBContext :IForumContext,IDisposable
    {
        private ForumContext context;

        public ForumDBContext()
        {
        }

        public ForumContext DbContext
        {
            get
            {
                if (context == null)
                {
                    context = new ForumContext();
                }
                return context;
            }
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public ForumContext GetForumContext()
        {
            return DbContext;
        }
    }
}