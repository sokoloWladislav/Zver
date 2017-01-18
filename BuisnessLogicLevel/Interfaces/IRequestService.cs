using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLogicLevel.Infrastructure;
using Models.Entities;

namespace BuisnessLogicLevel.Interfaces
{
    public interface IRequestService
    {
        OperationDetails CreateRequest(Request model);
        OperationDetails DeleteRequest(int id);
        List<Request> GetAllRequests();
    }
}
