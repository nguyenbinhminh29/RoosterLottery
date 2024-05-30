using RL.Application.Extensions;
using RL.Application.Interfaces;
using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RL.Application.Implements
{
    public class UserClientService : IUserClientService
    {
        private readonly HttpClient _client;

        public UserClientService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7266/")
            };
        }

        public async Task<GenericResult> UserLoginByPhone(string phoneNo)
        {
            HttpResponseMessage response = await _client.GetAsync("Users/UserLogin?phoneNo=" + phoneNo);

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

        public async Task<GenericResult> CreateUser(string name, DateTime birthday, string phoneNo)
        {
            UserModel model = new()
            {
                Name = name,
                Birthday = birthday,
                PhoneNo = phoneNo
            };

            string requestUri = $"Users/CreateUser";
            var content = new StringContent(model.ToJson(), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(requestUri, content);

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

        public async Task<GenericResult> GetUserTicket(string phoneNo, DateTime purchaseDate)
        {
            HttpResponseMessage response = await _client.GetAsync($"Users/UserTicket?phoneNo={phoneNo}&purchaseDate={purchaseDate:yyyy-MM-dd}");

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

        public async Task<GenericResult> SubmitUserTicket(string phoneNo, int newNumber, string lotteryPeriod)
        {
            UserTicketModel model = new()
            {
                PhoneNo = phoneNo,
                TicketNumber = newNumber,
                LotteryPeriod = lotteryPeriod
            };

            string requestUri = $"Users/BuyTicket";
            var content = new StringContent(model.ToJson(), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(requestUri, content);

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
