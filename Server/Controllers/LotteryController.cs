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

        [HttpGet("GetLottery")]
        public IActionResult GetLottery(string openDate)
        {
            try
            {
                GenericResult result = new();

                DateTime fdtEtd = DateTime.Now;
                if (!string.IsNullOrEmpty(openDate) && !DateTime.TryParseExact(openDate.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fdtEtd))
                {
                    result.Success = false;
                    result.Message = "OpenDate format must be 'yyyy-MM-dd'";

                    return BadRequest(result);
                }

                result = _lotteryService.GetLottery(openDate);
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

        [HttpGet("GetNextPeriod")]
        public IActionResult GetNextPeriod()
        {
            try
            {
                GenericResult result = new();

                result = _lotteryService.GetNextPeriod();
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
    }
}
