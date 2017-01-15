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
    public class RequestRepository : IRepository<Request>
    {
        private ApplicationContext db;

        public RequestRepository(ApplicationContext context)
        {
            db = context;
        }

        public void Create(Request item)
        {
            db.Requests.Add(item);
        }

        public void Delete(int id)
        {
            Request request = db.Requests.Find(id);
            if( request != null )
            {
                db.Requests.Remove(request);
            }
        }

        public void Update(Request item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }

        public Request Get(int id)
        {
            return db.Requests.Find(id);
        }

        public IEnumerable<Request> GetAll()
        {
            return db.Requests.ToList();
        }
        public IEnumerable<Request> Find(Func<Request, Boolean> predicate)
        {
            return db.Requests.Where(predicate);
        }
    }
}
