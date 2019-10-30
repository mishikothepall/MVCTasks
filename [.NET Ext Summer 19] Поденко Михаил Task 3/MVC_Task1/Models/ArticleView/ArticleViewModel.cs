using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.ArticleView
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        public int Rating { get; set; }

        public string ShortContent { get; set; }

        public ArticleViewModel(int id, string name, string date, string content, int rating) {

            Id = id;
            Name = name;
            Date = date;
            Content = content;
            Rating = rating;
            if (!string.IsNullOrEmpty(content) && !IsShort(content))
            {
                ShortContent = content.Substring(0, Math.Min(content.Length, 200)) + "...";
            }
            else {
                ShortContent = content;
            }
            
        }

        private bool IsShort(string s) => s.Length <= 200;
    }
}