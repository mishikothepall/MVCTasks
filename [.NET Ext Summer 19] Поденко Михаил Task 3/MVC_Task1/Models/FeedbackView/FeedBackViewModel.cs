using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.FeedbackView
{
    public class FeedBackViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Author { get; set; }

        public string Date { get; set; }

        public string Content { get; set; }

        public FeedBackViewModel Template { get; set; }

        public FeedBackViewModel() { }

        public FeedBackViewModel(int id, string name, string date, string content) {
            Id = id;
            Author = name;
            Date = date;
            Content = content;
        }
    }
}