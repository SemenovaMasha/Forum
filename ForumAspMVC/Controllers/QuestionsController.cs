using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ForumAspMVC.Core;
using ForumAspMVC.Models;

namespace ForumAspMVC.Controllers
{
    public class QuestionsController : Controller
    {
        private IUnitOfWork ForumUnitOfWork;
        public QuestionsController(IUnitOfWork unitOfWork)
        {
            ForumUnitOfWork = unitOfWork;
        }

        // GET: Questions
        public ActionResult Index()
        {

            ForumUnitOfWork.Questions.Add(new Question
                {
                    Title = "Help",
                    Text = "I have a problem",
                    Date = DateTime.Today.AddDays(-1)
                });

            ForumUnitOfWork.Questions.Add(new Question
                {
                Title = "It's time",
                    Text = "It time to begin, isn't it?",
                    Date = DateTime.Today
            });
            ForumUnitOfWork.Complete();


            //var Questions = new Question[] {new Question
            //{
            //    Id = Guid.NewGuid(),
            //    Title = "Help",
            //    Text = "I have a problem",
            //    Date = DateTime.Today.AddDays(-1)
            //},new Question
            //{
            //    Id = Guid.NewGuid(),
            //    Title = "It's time",
            //    Text = "It time to begin, isn't it?",
            //    Date = DateTime.Today
            //},};



            return View(ForumUnitOfWork.Questions.GetAll());
        }
    }
}