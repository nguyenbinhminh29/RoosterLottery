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
    public class UserService(IConfiguration config, IGenericRepository<UserModel> dbRepository) : IUserService
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
                        db.Execute("USP_UPDATE_UserLogin", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600); ;
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
                    parameters.Add("PhoneNo", user.PhoneNo);

                    var items = db.Query<UserModel>("USP_GET_UserByPhone", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    if (items.Any())
                    {
                        result.Success = false;
                        result.Message = "User already exists.";
                    }
                    else
                    {
                        parameters.Add("Name", user.Name);
                        parameters.Add("Birthday", user.Birthday);
                        // Insert new user
                        //db.Execute("USP_INSERT_NewUser", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);

                        var res = db.Query<DBResultModel>("USP_INSERT_NewUser", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);

                        result.Success= true;
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
