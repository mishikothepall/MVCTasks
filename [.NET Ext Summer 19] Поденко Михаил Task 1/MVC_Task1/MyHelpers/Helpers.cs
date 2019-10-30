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

        //public static MvcHtmlString CreateCheckbox(this HtmlHelper html, string qm, string name) {
        //    TagBuilder ch = new TagBuilder("p");
        //    TagBuilder lbl = new TagBuilder("label");
        //    lbl.SetInnerText(qm);
        //    TagBuilder chb = new TagBuilder("input");
        //    chb.MergeAttribute("type", "checkbox");
        //    chb.MergeAttribute("name", name);
        //    chb.MergeAttribute("value", qm);
        //    ch.InnerHtml += chb;
        //    ch.InnerHtml += lbl;
        //    return new MvcHtmlString(ch.ToString());
        //}

        public static MvcHtmlString CreateCheckbox(this HtmlHelper html, Variative qm, string name)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (string q in qm) {
                TagBuilder li = new TagBuilder("li");
                TagBuilder chb = new TagBuilder("input");
                TagBuilder lbl = new TagBuilder("label");
                chb.MergeAttribute("type", "checkbox");
                chb.MergeAttribute("name", name);
                chb.MergeAttribute("value", q);
                lbl.SetInnerText(q);
                li.InnerHtml += chb;
                li.InnerHtml += lbl;
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

        public static MvcHtmlString CreateRadio(this HtmlHelper html, Variative qm, string name)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (string q in qm)
            {
                TagBuilder li = new TagBuilder("li");
                TagBuilder chb = new TagBuilder("input");
                TagBuilder lbl = new TagBuilder("label");
                chb.MergeAttribute("type", "radio");
                chb.MergeAttribute("name", name);
                chb.MergeAttribute("value", q);
                lbl.SetInnerText(q);
                li.InnerHtml += chb;
                li.InnerHtml += lbl;
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

    }
}