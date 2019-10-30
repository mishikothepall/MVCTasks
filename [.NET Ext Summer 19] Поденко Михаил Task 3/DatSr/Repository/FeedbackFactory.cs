using DatSr.ContextData.FeedbackCon;
using DatSr.Entities.Feedbacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatSr.Repository
{
    public interface IManageFeedbacks {

        IGetFeeds GetInfo();
        IAddFeed AddInfo();

    }

    public interface IGetFeeds {

        IEnumerable<FeedbackModel> GetFeed();

    }

    public interface IAddFeed {

        IEnumerable<FeedbackModel> SaveFed(string dat);

    }

    class FeedbackFactory : IManageFeedbacks{

        public IAddFeed AddInfo()
        {
            return new Reply();
        }

        public IGetFeeds GetInfo()
        {
            return new AllFeed();
        }
    }

    class AllFeed : IGetFeeds{

        FeedbackContext db = new FeedbackContext();

        public IEnumerable<FeedbackModel> GetFeed()
        {
            return db.Feedbacks.ToList();
        }
    }

    class Reply : IAddFeed{

        FeedbackContext db = new FeedbackContext();

        public IEnumerable<FeedbackModel> SaveFed(string dat)
        {
            var info = dat.Split('/');

            int cnt = 0;

            FeedbackModel fm = new FeedbackModel();

            foreach (string s in info)
            {

                if (cnt == 0)
                {

                    fm.Author = s;

                    cnt++;

                    continue;

                }

                fm.Content = s;

            }
            db.Feedbacks.Add(fm);

            db.SaveChanges();

            return db.Feedbacks.ToList();
        }
    }
}
