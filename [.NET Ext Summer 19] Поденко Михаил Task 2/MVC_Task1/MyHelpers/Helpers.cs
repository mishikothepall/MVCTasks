using DatSr.Entities.Questions;
using MVC_Task1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Task1.MyHelpers
{
    public static class ListHelpers
    {

        public static MvcHtmlString CreateMainMenu(this HtmlHelper html) {

            TagBuilder a = new TagBuilder("a");
            a.MergeAttribute("href", "HomePage");
            a.SetInnerText("Главная");
            TagBuilder a1 = new TagBuilder("a");
            a1.MergeAttribute("href", "Guest");
            a1.SetInnerText("Гостевая");
            TagBuilder a2 = new TagBuilder("a");
            a2.MergeAttribute("href", "Quiz");
            a2.SetInnerText("Анкета");

            List<TagBuilder> tb = new List<TagBuilder>{ a, a1, a2};

            TagBuilder ul = new TagBuilder("ul");

            foreach (TagBuilder t in tb) {
                TagBuilder li = new TagBuilder("li");
                li.InnerHtml += t;
                ul.InnerHtml += li.ToString();
            }
            
            return new MvcHtmlString(ul.ToString());
        }


        public static MvcHtmlString CreateRadio(this HtmlHelper html, dynamic ls, string name)
        {
            TagBuilder ul = new TagBuilder("ul");
            QuestionModel qm = (QuestionModel)ls;
            foreach (VariantsModel s in qm.Vars)
            {
                TagBuilder li = new TagBuilder("li");
                TagBuilder inp = new TagBuilder("input");
                TagBuilder lbl = new TagBuilder("label");
                inp.MergeAttribute("type", "radio");
                inp.MergeAttribute("name", name);
                inp.MergeAttribute("value", s.Variant);
                lbl.SetInnerText(s.Variant);
                li.InnerHtml += inp;
                li.InnerHtml += lbl;
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

        public static MvcHtmlString CreateCheckbox(this HtmlHelper html, dynamic ls, string name)
        {
            TagBuilder ul = new TagBuilder("ul");
            QuestionModel qm = (QuestionModel)ls;
            foreach (VariantsModel s in qm.Vars)
            {
                TagBuilder li = new TagBuilder("li");
                TagBuilder inp = new TagBuilder("input");
                TagBuilder lbl = new TagBuilder("label");
                inp.MergeAttribute("type", "checkbox");
                inp.MergeAttribute("name", name);
                inp.MergeAttribute("value", s.Variant);
                lbl.SetInnerText(s.Variant);
                li.InnerHtml += inp;
                li.InnerHtml += lbl;
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

    }
}