using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.ArticleModels
{
    public class ArticleModel
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Contain { get; set; }

        public ArticleModel(DateTime dt) {
            Date = dt.ToShortDateString();
        }
    }
}