using DatSr.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.ContextData.QuestCon
{
    public class QuestionContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionModel>().HasKey(q => q.ID);
            modelBuilder.Entity<VariantsModel>().HasKey(v => v.VariantID);

            modelBuilder.Entity<QuestionModel>().HasMany(q => q.Vars).WithRequired(v => v.Quest);
            base.OnModelCreating(modelBuilder);
        }

        static QuestionContext(){
            Database.SetInitializer<QuestionContext>(new QuestionDbInitializer());
        }

        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<VariantsModel> Variants { get; set; }
    }
}
