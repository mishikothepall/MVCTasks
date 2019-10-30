using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Task1.Models.FeedBackModels
{
    public class FeedbackContext:DbContext
    {
        public DbSet<FeedbackMod> Feedbacks { get; set; }
    }
}