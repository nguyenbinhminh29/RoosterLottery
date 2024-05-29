using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RL.Application.Implements;
using RL.Application.Interfaces;
using RL.Data.Models;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LotteryController : ControllerBase
    {
        private ILotteryServerService _lotteryService;

        public LotteryController(ILotteryServerService lotteryService)
        {
            this._lotteryService = lotteryService;
        }

        //[HttpGet("GetLottery")]
        //public IActionResult Get(string phoneNo)
        //{
        //    try
        //    {
        //        GenericResult result = _userService.GetUser(phoneNo);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        GenericResult result = new()
        //        {
        //            Success = false,
        //            Message = ex.Message
        //        };

        //        return BadRequest(result);
        //    }
        //}
    }
}
