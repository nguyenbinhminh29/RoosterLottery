using RL.Application.Extensions;
using RL.Application.Interfaces;
using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Application.Implements
{
    public class LotteryClientService : ILotteryClientService
    {
        private readonly HttpClient _client;

        public LotteryClientService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7266/")
            };
        }

        public async Task<GenericResult> GetLotteryTransactions(DateTime openDate)
        {
            HttpResponseMessage response = await _client.GetAsync("Lottery/GetLottery?openDate=" + openDate.ToString("yyyy-MM-dd"));

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                GenericResult? result = responseBody.DeserializeObject<GenericResult>();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("An unknown error.");
                }
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }

        public async Task<GenericResult> GetNextLotteryPeriod()
        {
            HttpResponseMessage response = await _client.GetAsync("Lottery/GetNextPeriod");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                GenericResult? result = responseBody.DeserializeObject<GenericResult>();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("An unknown error.");
                }
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }

        public async Task<GenericResult> GetMonitorNumber(DateTime fromDate, DateTime toDate)
        {
            HttpResponseMessage response = await _client.GetAsync($"Lottery/MonitorNumber?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                GenericResult? result = responseBody.DeserializeObject<GenericResult>();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("An unknown error.");
                }
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }

        public async Task<GenericResult> GetMonitorUserTicket(DateTime fromDate, DateTime toDate)
        {
            HttpResponseMessage response = await _client.GetAsync($"Lottery/MonitorUser?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                GenericResult? result = responseBody.DeserializeObject<GenericResult>();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("An unknown error.");
                }
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }


    }
}
