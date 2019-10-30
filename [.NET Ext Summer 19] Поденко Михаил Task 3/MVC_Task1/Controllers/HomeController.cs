using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatSr;
using DatSr.Entities.Questions;
using MVC_Task1.Models.ArticleView;
using MVC_Task1.Models.FeedbackView;
using MVC_Task1.Models.QuizModels;

namespace MVC_Task1.Controllers
{
    public class HomeController : Controller
    {
        //Объект абстрактной фабрики из библиотеки классов
        FactoryContext fb = new FactoryContext();

        //Секция голосования
        public ActionResult Poll(int id=0) {

            


            if (id != 0)

            {
                HttpCookie cookie = new HttpCookie("My localhost cookie");

                cookie["itemId"] = id.ToString();

                cookie.Expires = DateTime.Now.AddYears(1);

                HttpContext.Response.Cookies.Add(cookie);

                fb.artc.Poll().Vote(id);
            }
         var q = fb.artc.Art().GetArticle();


            var dm = q.Select(m => new ArticleViewModel(
                m.ID,
                m.Name,
                m.Date,
                m.Contain,
                m.Rating
                ));

            return PartialView(dm);
        }


        //Голосование



        //Поиск статьи в Бд по ключу 
        public ActionResult GetArticle(int Id) {

            var q = fb.artc.Specific().Specific(Id);

            return View(q);
        }

        //Контроллер Главной страницы

        public ActionResult HomePage() {

            var q = fb.artc.Art().GetArticle();

            var dm = q.Select(m => new ArticleViewModel(

                m.ID,

                m.Name,

                m.Date,

                m.Contain,

                m.Rating

                ));

            return View(dm);
        }

 

        //Контроллер Гостевой

        public ActionResult Guest() {

            var q = fb.fds.GetInfo().GetFeed();

            var dm = q.Select(m => new FeedBackViewModel(

                m.ID,

                m.Author,

                m.Date,

                m.Content
                ));


            return View(dm.ToList());
        }
        
        //Логика добавления комментариев

        public ActionResult AddFeed(FeedBackViewModel fm) {
            if (HttpContext.Request.HttpMethod == "POST")
            {
                string res = $"{fm.Author}/{fm.Content}";

                var q = fb.fds.AddInfo().SaveFed(res);
            }
            var inf = fb.fds.GetInfo().GetFeed();

            var mod = inf.Select(m => new FeedBackViewModel(

                m.ID,

                m.Author,

                m.Date,

                m.Content
                ));


            return PartialView(mod.ToList());
            

        }

        //Контроллер Анкеты

        public ActionResult Quiz() {

            var q = fb.quest.GetInfo().GetInfo();

            var dm = q.Select(m => new QuizViewModel
            (
              m.Type,

              m.Question,

              m.Vars.Select(v => v.Variant)

             ));

            return View(dm);
        }

        //Контроллер результата анкетирования

        public ActionResult QuizSummary(FormCollection fc)
        {
            if (HttpContext.Request.HttpMethod == "POST")
            {
                List<AnswerModel> aml = new List<AnswerModel>();

                foreach (string key in fc.AllKeys)
                {
                    AnswerModel am = new AnswerModel();

                    if (!key.Equals("Submit"))
                    {

                        if (key.Contains("Variant"))
                        {

                            am.UserAnswer= fc[key];

                        }
                        else
                        {

                            am.Question = fc[key];

                        }

                    }

                    aml.Add(am);

                }
               
                return View(aml);

            }

            return RedirectToAction("HomePage");
        }
    }
}