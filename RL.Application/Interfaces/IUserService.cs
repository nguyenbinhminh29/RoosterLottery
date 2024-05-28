using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Application.Interfaces
{
    public interface IUserService
    {
        GenericResult GetUser(string phoneNo);
        GenericResult CreateUser(UserModel user);
    }
}
