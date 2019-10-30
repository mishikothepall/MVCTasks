using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Task1.Models;
using MVC_Task1.Models.ArticleModels;
using MVC_Task1.Models.FeedBackModels;
using MVC_Task1.Models.QuizModels;

namespace MVC_Task1.Controllers
{
    public class HomeController : Controller
    {
        QuizContext qc = new QuizContext();
        ArticleContext ac = new ArticleContext();
        FeedbackContext fc = new FeedbackContext();


        public ActionResult HomePage() {
            ViewBag.Article = ac;
            return View();
        }

        public ActionResult Guest() {
            IEnumerable<FeedbackMod> mod = fc.Feedbacks;
            ViewBag.Fds = mod;
            return View();
        }

        public string Error() {
            return "Please enter your username";
        }

        public ActionResult AddFed(FeedbackMod fm) {
            if (fm.Author != null)
            {
                fc.Feedbacks.Add(fm);
                fc.SaveChanges();
                return RedirectToAction("Guest");
            }
            return RedirectToAction("Error"); 
        }

        public ActionResult Quiz() {
     
            ViewBag.Ql = qc;
            return View();
        }

       
        public ActionResult QuizSummary(FormCollection fc) {
            if (HttpContext.Request.HttpMethod == "POST")
            {
                List<AnswerModel> aml = new List<AnswerModel>();
                foreach (string key in fc.AllKeys)
                {
                    AnswerModel am = new AnswerModel();

                    if (!key.Equals("Submit"))
                    {

                        if (key.Contains("Answer"))
                        {
                            am.UserAnswer = fc[key];
                        }
                        else
                        {
                            am.Question = fc[key];

                        }

                    }

                    aml.Add(am);
                }

                ViewBag.Vals = aml;
                return View();
            }
            return RedirectToAction("HomePage");
        } 
    }
}