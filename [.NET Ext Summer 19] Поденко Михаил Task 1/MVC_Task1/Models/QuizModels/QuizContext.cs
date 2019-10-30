using MVC_Task1.Models.QuizModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models
{
    public class QuizContext:IEnumerable
    {
        public FreeAnswer fe1 = new FreeAnswer(1, "Введите ваше имя.");
        public FreeAnswer fe2 = new FreeAnswer(1, "Введите вашу фамилию.");
        public FreeAnswer fe3 = new FreeAnswer(1, "Введите ваш адресс.");
        public Variative v1 = new Variative(3,"Укажите ваш пол", "Мужчина./Женщина.");
        public Variative v2 = new Variative(3, "Хотели бы Вы работать у нас в компании?", "Да./Нет.");
        public Variative v3 = new Variative(3, "Готовы ли вы работать в 3 смены?", "Да./Нет.");
        public Variative v4 = new Variative(3, "Какое ваше любимое животное?", "Кошка./Собака./Хомячок.");
        public Variative v5 = new Variative(2, "Что привлекает Вас в нашей компании?",  "Высокая заработная плата./Дружный коллектив./Интересные проекты.");
        public Variative v6 = new Variative(2, "Что для Вас самое главное в жизни?", "Семья./Работа./Родители./Родина./Выпить пива с друзьями после работы.");


        public List<QuestionMod> ql;

        public QuizContext() {

            ql = new List<QuestionMod>();

            ql.Add(fe1);
            ql.Add(fe2);
            ql.Add(fe3);
            ql.Add(v1);
            ql.Add(v2);
            ql.Add(v3);
            ql.Add(v4);
            ql.Add(v5);
            ql.Add(v6);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (QuestionMod qm in ql) {
                yield return qm;
            }
        }
    }
}