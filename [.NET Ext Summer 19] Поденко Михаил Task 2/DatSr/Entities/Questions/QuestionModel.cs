using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.Entities.Questions
{
    public class QuestionModel
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public string Question { get; set; }

        public List<VariantsModel> Vars { get; set; }

        public QuestionModel() {
            Vars = new List<VariantsModel>();
        }
    }
}
