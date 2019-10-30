using DatSr.Entities.Feedbacks;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.ContextData.FeedbackCon
{
    public class FeedbackDbInitializer2:DropCreateDatabaseAlways<FeedbackContext>
    {
        protected override void Seed(FeedbackContext context)
        {
            context.Feedbacks.Add(new FeedbackModel { Author = "Вася", Date = new DateTime(2018, 02, 05).ToShortDateString(), Content = "Здесь был Вася." });
            context.Feedbacks.Add(new FeedbackModel { Author = "Cheeki_breeker228", Date = new DateTime(2019, 01, 03).ToShortDateString(), Content = "Я маслину поймал." });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
