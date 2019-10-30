using DatSr.Entities.Feedbacks;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.ContextData.FeedbackCon
{
    public class FeedbackContext:DbContext
    {
        static FeedbackContext() {
            Database.SetInitializer<FeedbackContext>(new FeedbackDbInitializer2());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackModel>().HasKey(f=>f.ID);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FeedbackModel> Feedbacks { get; set; }
    }
}
