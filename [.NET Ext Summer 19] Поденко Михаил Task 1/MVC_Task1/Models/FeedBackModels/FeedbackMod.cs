using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.FeedBackModels
{
    public class FeedbackMod
    {
        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public FeedbackMod() {
            Date = DateTime.Now.ToShortDateString();
        }
    }
}