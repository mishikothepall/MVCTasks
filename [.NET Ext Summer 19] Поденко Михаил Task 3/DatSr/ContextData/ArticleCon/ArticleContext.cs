using DatSr.Entities.Articles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.ContextData.ArticleCon
{
    public class ArticleContext:DbContext
    {
        static ArticleContext()
        {
            Database.SetInitializer<ArticleContext>(new ArticleDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleModel>().HasKey(a => a.ID);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ArticleModel> Articles { get; set; }
    }
}
