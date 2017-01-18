using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLogicLevel.Interfaces;
using BuisnessLogicLevel.Infrastructure;
using DataAccessLevel.EntityFramework;
using DataAccessLevel.Interfaces;
using DataAccessLevel.Repositories;
using Models.Entities;

namespace BuisnessLogicLevel.Servicies
{
    public class RequestService : IRequestService
    {
        private ApplicationContext db;
        private IRepository<Request> requestRepository;

        public RequestService(string conectionString)
        {
            db = new ApplicationContext(conectionString);
            requestRepository = new RequestRepository(db);
        }

        public OperationDetails CreateRequest(Request model)
        {
            var request = requestRepository.Get(model.Id);
            if(request == null)
            {
                requestRepository.Create(model);
                db.SaveChanges();
                return new OperationDetails
                {
                    Success = true,
                    Property = "",
                    Message = ""
                };
            }
            return new OperationDetails
            {
                Success = false,
                Property = "Id",
                Message = "the request with such id already exists"
            };
        }

        public OperationDetails DeleteRequest(int id)
        {
            Request request = requestRepository.Get(id);
            if(request != null)
            {
                requestRepository.Delete(id);
                db.SaveChanges();
                return new OperationDetails
                {
                    Success = true,
                    Property = "",
                    Message = ""
                };
            }
            else
            {
                return new OperationDetails
                {
                    Success = false,
                    Property = "Id",
                    Message = "Request to delete is not exist in database"
                };
            }
        }

        public List<Request> GetAllRequests()
        {
            return db.Requests.ToList();
        }
    }
}
