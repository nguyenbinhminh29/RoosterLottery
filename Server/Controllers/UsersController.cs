using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("GetUserInfo")]
        public Greeting Get()
        {
            return new Greeting { Message = "Good luck to you!" };
        }
    }
}
