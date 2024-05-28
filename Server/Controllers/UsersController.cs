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
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("UserLogin")]
        public IActionResult Get(string phoneNo)
        {
            GenericResult result = _userService.GetUser(phoneNo);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
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

                if (string.IsNullOrEmpty(user.PhoneNo))//!user.PhoneNo.IsValidPhoneNumber())
                {
                    result.Success = false;
                    result.Message = "Phone number is incorrect.";
                    return BadRequest(result);
                }

                result = _userService.CreateUser(user);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
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
