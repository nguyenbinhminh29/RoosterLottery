using Dapper;
using Microsoft.Extensions.Configuration;
using RL.Application.Interfaces;
using RL.Data.Models;
using RL.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Application.Implements
{
    public class UserServerService(IConfiguration config, IGenericRepository<UserModel> dbRepository) : IUserServerService
    {
        private readonly IGenericRepository<UserModel> _dbRepository = dbRepository;
        private readonly IConfiguration _config = config;

        public GenericResult GetUser(string phoneNo)
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);
                    var parameters = new DynamicParameters();
                    parameters.Add("PhoneNo", phoneNo);

                    var items = db.Query<UserModel>("USP_GET_UserByPhone", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    if (items.Any())
                    {
                        result.Data = items.FirstOrDefault();
                        result.Success = true;

                        // update login
                        db.Execute("USP_UPDATE_UserLogin", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = "User does not exist.";
                    }
                }
                else
                {
                    result.Success = false;
                    result.Message = "Cannot connect to database.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Code = 400;
                result.Message = "Exception: " + ex.Message;
            }
            return result;
        }

        public GenericResult CreateUser(UserModel user)
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);
                    var parameters = new DynamicParameters();
                    parameters.Add("Name", user.Name);
                    parameters.Add("PhoneNo", user.PhoneNo);
                    parameters.Add("Birthday", user.Birthday);

                    IEnumerable<DBResultModel> res = db.Query<DBResultModel>("USP_INSERT_NewUser", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);

                    if (res.Any())
                    {
                        if (res.FirstOrDefault().ErrCode == 0)
                        {
                            result.Success = true;
                        }
                        else
                        {
                            result.Success = false;
                        }
                        result.Message = res.FirstOrDefault().ErrMsg;
                        result.Data = user;
                    }
                    else
                    {
                        result.Success = false;
                    }
                }
                else
                {
                    result.Success = false;
                    result.Message = "Cannot connect to database.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Code = 400;
                result.Message = "Exception: " + ex.Message;
            }
            return result;
        }

        public GenericResult GetUserTicket(string phoneNo, string purchaseDate)
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);
                    var parameters = new DynamicParameters();
                    parameters.Add("PhoneNo", phoneNo);
                    parameters.Add("PhoneNo", phoneNo);
                    if (string.IsNullOrEmpty(purchaseDate))
                    {
                        parameters.Add("PurchaseDate", null);
                    }
                    else
                    {
                        parameters.Add("PurchaseDate", purchaseDate);
                    }

                    var items = db.Query<TicketModel>("USP_GET_UserTicket", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    if (items.Any())
                    {
                        result.Data = items;
                    }
                    else
                    {
                        result.Data=new List<TicketModel>();
                    }
                        result.Success = true;
                }
                else
                {
                    result.Success = false;
                    result.Message = "Cannot connect to database.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Code = 400;
                result.Message = "Exception: " + ex.Message;
            }
            return result;
        }

        public GenericResult CreateUserTicket(UserTicketModel userTicket)
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);
                    var parameters = new DynamicParameters();
                    parameters.Add("PhoneNo", userTicket.PhoneNo);
                    parameters.Add("TicketNum", userTicket.TicketNumber);
                    parameters.Add("LotteryPeriod", userTicket.LotteryPeriod);

                    IEnumerable<DBResultModel> res = db.Query<DBResultModel>("USP_INSERT_UserTicket", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);

                    if (res.Any())
                    {
                        if (res.FirstOrDefault().ErrCode == 0)
                        {
                            result.Success = true;
                        }
                        else
                        {
                            result.Success = false;
                        }
                        result.Message = res.FirstOrDefault().ErrMsg;
                        result.Data = userTicket;
                    }
                    else
                    {
                        result.Success = false;
                    }
                }
                else
                {
                    result.Success = false;
                    result.Message = "Cannot connect to database.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Code = 400;
                result.Message = "Exception: " + ex.Message;
            }
            return result;
        }
    }
}
