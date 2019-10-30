using DatSr.Entities.Questions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.QuizModels
{
    //Класс шаблон для компоновки результатов анетирования в отдельную форму с БД никак не связан
    public class AnswerModel
    {
        public string Question { get; set; }

        public string UserAnswer { get; set; }

    }
}