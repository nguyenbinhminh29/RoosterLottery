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

        public GenericResult GetMonitoringLotteryNumber(string fromDate, string toDate)
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);
                    var parameters = new DynamicParameters();
                    parameters.Add("FromDate", fromDate);
                    parameters.Add("ToDate", toDate);

                    var items = db.Query<LotteryChartsModel>("USP_GET_MonitoringLotteryNumber", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    if (items.Any())
                    {
                        result.Data = items;
                    }
                    else
                    {
                        result.Data = new List<LotteryChartsModel>();
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

        public GenericResult GetMonitoringLotteryUserTicket(string fromDate, string toDate)
        {
            GenericResult result = new();
            try
            {
                string? connectStr = _config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrEmpty(connectStr))
                {
                    using var db = _dbRepository.GetConnection(connectStr);
                    var parameters = new DynamicParameters();
                    parameters.Add("FromDate", fromDate);
                    parameters.Add("ToDate", toDate);

                    var reader = db.QueryMultiple("USP_GET_MonitoringLotteryUserTicket", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3600);
                    if (reader != null)
                    {
                        List<List<LotteryChartsModel>> lotteryCharts = [];
                        List<LotteryChartsModel> listCheck = reader.Read<LotteryChartsModel>().ToList();
                        if (listCheck.Count > 0)
                        {
                            var first = listCheck.FirstOrDefault();
                            if (first != null)
                            {
                                for (int i = 0; i < first.Value; i++)
                                {
                                    List<LotteryChartsModel> lst = reader.Read<LotteryChartsModel>().ToList();
                                    lotteryCharts.Add(lst);
                                }
                            }
                        }
                        result.Data = lotteryCharts;
                    }
                    else
                    {
                        result.Data = new List<List<LotteryChartsModel>>();
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
