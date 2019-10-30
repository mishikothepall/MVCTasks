using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.Entities.Questions
{
    public class VariantsModel
    {
        public int VariantID { get; set; }
        public string Variant { get; set; }
        public Nullable<int> QuestID { get; set; }

        public QuestionModel Quest { get; set; }
    }
}
