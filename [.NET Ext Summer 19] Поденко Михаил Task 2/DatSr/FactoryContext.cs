using DatSr.ContextData.ArticleCon;
using DatSr.ContextData.FeedbackCon;
using DatSr.ContextData.QuestCon;
using DatSr.Entities.Feedbacks;
using DatSr.Entities.Questions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr
{
    //Абстрактная Фабрика
    public interface DataOp
    {

        ChangeDb EditDb();
        GetInfo Info();

    }

    //Конкретная фабрика для Анкеты
    class ConcreteQuizData : DataOp
    {
        public ChangeDb EditDb()
        {
            throw new NotImplementedException();
        }

        public GetInfo Info()
        {
            return new QuizInfo();
        }
    }

    //Конкретная фабрика для отзывов
    class ConcreteFedbackData : DataOp
    {


        public ChangeDb EditDb()
        {
            return new FeedbackEdit();
        }

        public GetInfo Info()
        {
            return new FeedBackInfo();
        }
    }

    //Конкретная фабрика для главной
    class ConcreteHomeData : DataOp
    {
        public ChangeDb EditDb()
        {
            throw new NotImplementedException();
        }

        public GetInfo Info()
        {
            return new HomeInfo();
        }
    }

    //Интерфейс для редактирования БД
    public interface ChangeDb
    {
        IEnumerable SaveData(string dat);
    }

    //Добавление отзывов
    class FeedbackEdit : ChangeDb
    {
        FeedbackContext fc = new FeedbackContext();

        public IEnumerable SaveData(string dat)
        {
            var info = dat.Split('/');
            int cnt = 0;
            FeedbackModel fm = new FeedbackModel();
            foreach (string s in info)
            {
                if (cnt == 0)
                {
                    fm.Author = s;
                    cnt++;
                    continue;
                }
                fm.Content = s;
            }
            fc.Feedbacks.Add(fm);
            fc.SaveChanges();
            return fc.Feedbacks.ToList();
        }
    }

    //Интерфейс для получения информации из БД
    public interface GetInfo
    {
        IEnumerable GetData();
    }

    //Извлечение инфы из анкеты
    class QuizInfo : GetInfo
    {

        QuestionContext db = new QuestionContext();

        public IEnumerable GetData()
        {
            var info = db.Questions.Include("Vars");
            return info.ToList();
        }
    }

    //Извлечение отзывов
    class FeedBackInfo : GetInfo
    {
        FeedbackContext fc = new FeedbackContext();

        public IEnumerable GetData()
        {
            return fc.Feedbacks.ToList();
        }
    }

    //Извлечение статей
    class HomeInfo : GetInfo
    {
        ArticleContext ac = new ArticleContext();

        public IEnumerable GetData()
        {
            return ac.Articles.ToList();
        }
    }
    public class FactoryContext
    {
        public DataOp questions = new ConcreteQuizData();    //Доступ к анкете
        public DataOp feedbacks = new ConcreteFedbackData(); //Доступ к отзывам
        public DataOp article = new ConcreteHomeData();      //Доступ к статьям
    }
}
