using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Application.Interfaces
{
    public interface IUserClientService
    {
        Task<GenericResult> UserLoginByPhone(string phoneNo);
        Task<GenericResult> CreateUser(string name, DateTime birthday, string phoneNo);
        Task<GenericResult> GetUserTicket(string phoneNo, DateTime purchaseDate);
        Task<GenericResult> SubmitUserTicket(string phoneNo, int newNumber, string lotteryPeriod);
    }
}
