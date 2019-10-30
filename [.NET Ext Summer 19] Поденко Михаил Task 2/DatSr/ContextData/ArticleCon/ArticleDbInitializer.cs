using DatSr.Entities.Articles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.ContextData.ArticleCon
{
    public class ArticleDbInitializer:DropCreateDatabaseAlways<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            context.Articles.Add(new ArticleModel { Name = "ASP.NET MVC Framework", Date= new DateTime(2018, 08, 11).ToShortDateString(), Contain = "ASP.NET MVC Framework — фреймворк для создания веб-приложений, который реализует шаблон Model-view-controller. В апреле 2009 года исходный код ASP.NET MVC был опубликован под лицензией Microsoft Public License(MS - PL)[2]. 27 марта 2012 года лицензия была изменена на Apache License 2.0 В настоящее время разрабатывается ASP.NET MVC 6, как часть ASP.NET Core; 27 июня 2016 года состоялся выход версии 1.0.0" });
            context.Articles.Add(new ArticleModel { Name = "Основные компоненты ASP.NET MVC", Date = new DateTime(2018, 05, 02).ToShortDateString(), Contain = "Платформа ASP.NET MVC базируется на взаимодействии трех компонентов: контроллера, модели и представления. Контроллер принимает запросы, обрабатывает пользовательский ввод, взаимодействует с моделью и представлением и возвращает пользователю результат обработки запроса. Модель представляет слой, описывающий логику организации данных в приложении.Представление получает данные из контроллера и генерирует элементы пользовательского интерфейса для отображения информации." });
            context.Articles.Add(new ArticleModel { Name = "Движок представлений", Date = new DateTime(2019, 07, 09).ToShortDateString(), Contain = "Для управления разметкой и вставками кода в представлении используется движок представлений. До версии MVC 5 использовались два движка: Web Forms и Razor. Начиная с MVC 5 единственным движком, встроенным по умолчанию, является Razor.Движок WebForms использует файлы.aspx, а Razor — файлы.cshtml и.vbhtml для хранения кода представлений.Основой синтаксиса Razor является знак @, после которого осуществляется переход к коду на языках C#/VB.NET. Также возможно и использование сторонних движков. Файлы представлений не являются стандартными статическими страницами с кодом html, а в процессе генерации контроллером ответа с использованием представлений компилируются в классы, из которых затем генерируется страница html." });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
