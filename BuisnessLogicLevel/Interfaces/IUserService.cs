using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using BuisnessLogicLevel.BuisnessLogicEntities;

namespace BuisnessLogicLevel.Interfaces
{
    public interface IUserService
    {
        Task<ClaimsIdentity> Authenticate(UserTransferModel user);
    }
}
