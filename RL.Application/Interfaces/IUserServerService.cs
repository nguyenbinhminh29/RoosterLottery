using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Application.Interfaces
{
    public interface IUserServerService
    {
        GenericResult GetUser(string phoneNo);
        GenericResult CreateUser(UserModel user);
        GenericResult GetUserTicket(string phoneNo, string purchaseDate);
        GenericResult CreateUserTicket(UserTicketModel userTicket);
    }
}
