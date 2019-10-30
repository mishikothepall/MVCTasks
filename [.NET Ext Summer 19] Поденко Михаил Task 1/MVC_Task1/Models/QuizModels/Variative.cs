using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models
{
    public class Variative : QuestionMod, IEnumerable
    {
        public override string Question { get ; set; }
        public override string UserAnswer { get; set; }
        public  int Type { get; set; }

        public string Variants { get; set; }

        public List<string> ls;

        public Variative() { }

        public Variative(int type, string question, string vars) {
            ls = new List<string>();
            Question = question;
            Variants = vars;
            Type = type;
           
        }

        public void Add(string s) {
            ls.Add(s);
        }

      

        public IEnumerator GetEnumerator()
        {
            var splt = Variants.Split('/');
            foreach (string s in splt) { yield return s; }
        }
    }
}