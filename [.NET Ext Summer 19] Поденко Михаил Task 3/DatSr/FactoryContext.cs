using DatSr.ContextData.ArticleCon;
using DatSr.ContextData.FeedbackCon;
using DatSr.ContextData.QuestCon;
using DatSr.Entities.Articles;
using DatSr.Entities.Feedbacks;
using DatSr.Entities.Questions;
using DatSr.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr
{


    public class FactoryContext
    {

        //Домашняя
        public IManageArticle artc = new ArticleFactory();

        //Отзывы
        public IManageFeedbacks fds = new FeedbackFactory();

        //Анкета
        public IQuestManager quest = new QuestionFactory();

    }
}
