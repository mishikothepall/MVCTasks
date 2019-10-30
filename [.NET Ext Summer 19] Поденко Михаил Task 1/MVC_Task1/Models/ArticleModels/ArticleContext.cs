using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.ArticleModels
{
    public class ArticleContext : IEnumerable
    {
        ArticleModel am1 = new ArticleModel(new DateTime(2018, 08, 11)) { Name = "ASP.NET MVC Framework", Contain = "ASP.NET MVC Framework — фреймворк для создания веб-приложений, который реализует шаблон Model-view-controller. В апреле 2009 года исходный код ASP.NET MVC был опубликован под лицензией Microsoft Public License(MS - PL)[2]. 27 марта 2012 года лицензия была изменена на Apache License 2.0 В настоящее время разрабатывается ASP.NET MVC 6, как часть ASP.NET Core; 27 июня 2016 года состоялся выход версии 1.0.0" };
        ArticleModel am2 = new ArticleModel(new DateTime(2018, 05, 02)) { Name = "Основные компоненты ASP.NET MVC", Contain= "Платформа ASP.NET MVC базируется на взаимодействии трех компонентов: контроллера, модели и представления. Контроллер принимает запросы, обрабатывает пользовательский ввод, взаимодействует с моделью и представлением и возвращает пользователю результат обработки запроса. Модель представляет слой, описывающий логику организации данных в приложении.Представление получает данные из контроллера и генерирует элементы пользовательского интерфейса для отображения информации."};
        ArticleModel am3 = new ArticleModel(new DateTime(2019, 07, 09)) { Name = "Движок представлений", Contain = "Для управления разметкой и вставками кода в представлении используется движок представлений. До версии MVC 5 использовались два движка: Web Forms и Razor. Начиная с MVC 5 единственным движком, встроенным по умолчанию, является Razor.Движок WebForms использует файлы.aspx, а Razor — файлы.cshtml и.vbhtml для хранения кода представлений.Основой синтаксиса Razor является знак @, после которого осуществляется переход к коду на языках C#/VB.NET. Также возможно и использование сторонних движков. Файлы представлений не являются стандартными статическими страницами с кодом html, а в процессе генерации контроллером ответа с использованием представлений компилируются в классы, из которых затем генерируется страница html." };

        List <ArticleModel> aml;
        public ArticleContext()
        {
            aml = new List<ArticleModel>();
            
            aml.Add(am1);
            aml.Add(am2);
            aml.Add(am3);
;

        }

        public IEnumerator GetEnumerator()
        {
            foreach (ArticleModel am in aml)
            {
                yield return am;
            }
        }
    }
}