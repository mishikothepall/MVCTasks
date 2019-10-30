using DatSr.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.QuizModels
{
    public class QuizViewModel
    {

        public int Type { get; set; }

        public string Question { get; set; }

        public IEnumerable<string> Vars { get; set; }

        public QuizViewModel(int type, string question, IEnumerable<string> vs) {

            Type = type;
            Question = question;
            Vars = vs;

        }

    }
}