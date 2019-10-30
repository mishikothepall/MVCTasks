using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatSr;
using MVC_Task1.Models.QuizModels;

namespace MVC_Task1.Controllers
{
    public class HomeController : Controller
    {
        //Объект абстрактной фабрики из библиотеки классов
        FactoryContext fb = new FactoryContext();

        //Контроллер Главной страницы
        public ActionResult HomePage() {
            var mod = fb.article.Info().GetData();
            return View(mod);
        }

        //Контроллер Гостевой
        public ActionResult Guest() {
            var mod = fb.feedbacks.Info().GetData();
            return View(mod);
        }
        
        //Логика добавления комментариев
        public ActionResult AddFeed(FormCollection fc) {
            string name = string.Empty;
            string content = string.Empty;
            foreach (string key in fc.AllKeys)
            {
                if (!key.Equals("Submit"))
                {
                    if (key.Equals("Author"))
                    {
                           name = fc[key];
                    }
                    else
                    {
                        content = fc[key];
                    }
                }
            }
            string res = $"{name}/{content}";
            var mod = fb.feedbacks.EditDb().SaveData(res);
            var modInf = fb.feedbacks.Info().GetData();
            return RedirectToAction("Guest");
        }

        //Контроллер Анкеты
        public ActionResult Quiz() {

            var mod = fb.questions.Info().GetData();
            return View(mod);
        }

       //Контроллер результата анкетирования
        public ActionResult QuizSummary(FormCollection fc) {
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