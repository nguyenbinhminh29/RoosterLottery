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
    public class LotteryServerService(IConfiguration config, IGenericRepository<LotteryModel> dbRepository) : ILotteryServerService
    {
        private readonly IGenericRepository<LotteryModel> _dbRepository = dbRepository;
        private readonly IConfiguration _config = config;

        /// <summary>
        /// Get Lottery transactions
        /// </summary>
        /// <param name="openDate">Format date: yyyy-MM-dd</param>
        /// <returns></returns>
        public GenericResult GetLottery(string openDate)
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);
                    var parameters = new DynamicParameters();
                    if (string.IsNullOrEmpty(openDate))
                    {
                        parameters.Add("OpenDate", null);
                    }
                    else
                    {
                        parameters.Add("OpenDate", openDate);
                    }

                    var items = db.Query<LotteryModel>("USP_GET_LotteryTrans", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    if (items.Any())
                    {
                        result.Data = items;
                    }
                    else
                    {
                        result.Data = new List<LotteryModel>();
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

        public GenericResult GetNextPeriod()
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);

                    var items = db.Query<LotteryModel>("USP_GET_NextLotteryPeriod", commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    if (items.Any())
                    {
                        result.Data = items;
                    }
                    else
                    {
                        result.Data = new List<LotteryModel>();
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
    }
}
