using DatSr.ContextData.ArticleCon;
using DatSr.Entities.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.Repository
{
    public interface IManageArticle {
        IVote Poll();
        IArticle Art();
        ISpecArticle Specific();
    }

    public interface IVote {
        void Vote(int id);
    }

    public interface IArticle {
        IEnumerable<ArticleModel> GetArticle();
    }

    public interface ISpecArticle {
        IEnumerable<ArticleModel> Specific(int id);
    }
    class ArticleFactory : IManageArticle
    {
        public IArticle Art()
        {
            return new Info();
        }

        public IVote Poll()
        {
            return new Voter();
        }

        public ISpecArticle Specific()
        {
            return new SpecificArt();
        }
    }

    class Info : IArticle
    {
        ArticleContext db = new ArticleContext();
        public IEnumerable<ArticleModel> GetArticle()
        {
            return db.Articles.ToList();
        }
    }

    class SpecificArt : ISpecArticle
    {
        ArticleContext db = new ArticleContext();
        IEnumerable<ArticleModel> ISpecArticle.Specific(int id)
        {
            var q = db.Articles.Where(m => m.ID == id);

            return q.ToList();
        }
    }

    class Voter : IVote {
        ArticleContext db = new ArticleContext();


        void IVote.Vote(int id)
        {
            var article = db.Articles.Find(id);

            article.Rating += 1;

            db.SaveChanges();
        }
    }
}
