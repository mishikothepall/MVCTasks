using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models
{
    public abstract class QuestionMod
    {
        public abstract String Question { get; set; }
        public abstract String UserAnswer { get; set; }
        
    }
}