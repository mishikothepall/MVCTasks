using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models
{
    public class FreeAnswer : QuestionMod
    {
        public override string Question { get ; set ; }
        public override string UserAnswer { get; set; }
        public int Type { get; set ; }

        public FreeAnswer(int type, string question ) {
            Question = question;
            Type = type;
        }
    }
}