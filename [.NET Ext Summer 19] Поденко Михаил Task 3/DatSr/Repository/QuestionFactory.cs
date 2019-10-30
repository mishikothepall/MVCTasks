using DatSr.ContextData.QuestCon;
using DatSr.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.Repository
{
    public interface IQuestManager {
        IGetQuestInfo GetInfo();
    }

    public interface IGetQuestInfo {
        IEnumerable<QuestionModel> GetInfo();
    }

    class QuestionFactory : IQuestManager
    {
        public IGetQuestInfo GetInfo()
        {
            return new QuestInfo();
        }
    }

    class QuestInfo : IGetQuestInfo
    {
        QuestionContext db = new QuestionContext();

        public IEnumerable<QuestionModel> GetInfo()
        {
            return db.Questions.Include("Vars").ToList();
        }
    }
}
