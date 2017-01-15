using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Models.Entities;
using BuisnessLogicLevel.Infrastructure;

namespace BuisnessLogicLevel.Interfaces
{
    public interface IUserService
    {
        Task<ClaimsIdentity> Authenticate(UserModel user);
    }
}
