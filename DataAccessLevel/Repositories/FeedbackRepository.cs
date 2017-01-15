using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLevel.Interfaces;
using DataAccessLevel.EntityFramework;
using Models.Entities;

namespace DataAccessLevel.Repositories
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        private ApplicationContext context;

        public FeedbackRepository(string conectionString)
        {
            context = new ApplicationContext(conectionString);
        }

        public void Create(Feedback feedback)
        {
                context.Feedbacks.Add(feedback);
        }

        public void Delete(int id)
        {
            Feedback feedback = context.Feedbacks.Find(id);
            if (feedback != null)
            {
                context.Feedbacks.Remove(feedback);
            }
        }

        public void Update(Feedback item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }

        public Feedback Get(int id)
        {
            return context.Feedbacks.Find(id);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return context.Feedbacks.ToList();
        }
        public IEnumerable<Feedback> Find(Func<Feedback, Boolean> predicate)
        {
            return context.Feedbacks.Where(predicate);
        }
    }
}
