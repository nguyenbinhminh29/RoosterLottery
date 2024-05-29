using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RL.Application.Extensions;
using RL.Application.Interfaces;
using RL.Data.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserServerService _userService;

        public UsersController(IUserServerService userService)
        {
            _userService = userService;
        }

        [HttpGet("UserLogin")]
        public IActionResult Get(string phoneNo)
        {
            try
            {
                GenericResult result = _userService.GetUser(phoneNo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                GenericResult result = new()
                {
                    Success = false,
                    Message = ex.Message
                };

                return BadRequest(result);
            }
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] UserModel user)
        {
            GenericResult result = new();
            try
            {
                if (user == null)
                {
                    result.Success = false;
                    result.Message = "User data must be not null.";
                    return BadRequest(result);
                }

                if (string.IsNullOrEmpty(user.Name))
                {
                    result.Success = false;
                    result.Message = "User name must be not null.";
                    return BadRequest(result);
                }

                if (string.IsNullOrEmpty(user.PhoneNo))
                {
                    result.Success = false;
                    result.Message = "Phone number is incorrect.";
                    return BadRequest(result);
                }

                result = _userService.CreateUser(user);
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                return BadRequest(result);
            }
        }

        [HttpGet("UserTicket")]
        public IActionResult GetUserTicket(string phoneNo)
        {
            try
            {
                GenericResult result = _userService.GetUser(phoneNo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                GenericResult result = new()
                {
                    Success = false,
                    Message = ex.Message
                };

                return BadRequest(result);
            }
        }

        [HttpPost("BuyTicket")]
        public IActionResult UserBuyTicket([FromBody] UserTicketModel userTicket)
        {
            GenericResult result = new();
            try
            {
                if (userTicket == null)
                {
                    result.Success = false;
                    result.Message = "User ticket must be not null.";
                    return BadRequest(result);
                }

                if (string.IsNullOrEmpty(userTicket.PhoneNo))
                {
                    result.Success = false;
                    result.Message = "PhoneNo must be not null.";
                    return BadRequest(result);
                }

                result = _userService.CreateUserTicket(userTicket);
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                return BadRequest(result);
            }
        }
    }
}
