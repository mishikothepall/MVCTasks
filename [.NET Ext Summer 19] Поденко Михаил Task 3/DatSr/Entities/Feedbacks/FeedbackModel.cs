using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.Entities.Feedbacks
{
    public class FeedbackModel
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public FeedbackModel() {
            Date = DateTime.Now.ToShortDateString();
        }
    }
}
