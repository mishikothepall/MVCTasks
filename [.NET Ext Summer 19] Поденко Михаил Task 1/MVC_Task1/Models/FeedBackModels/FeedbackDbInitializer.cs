using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.FeedBackModels
{
    public class FeedbackDbInitializer:CreateDatabaseIfNotExists<FeedbackContext>
    {
        protected override void Seed(FeedbackContext fc)
        {
            fc.Feedbacks.Add(new FeedbackMod { Author = "Вася", Date = new DateTime(2018, 02, 05).ToShortDateString(), Content = "Здесь был Вася." });
            fc.Feedbacks.Add(new FeedbackMod{Author = "Cheeki_breeker228", Date = new DateTime(2019, 01, 03).ToShortDateString(), Content="Я маслину поймал."});

            base.Seed(fc);
        }
    }
}