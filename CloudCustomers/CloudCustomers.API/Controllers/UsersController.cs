using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly ILogger<UsersController> logger;
        public UsersController(/*ILogger<UsersController> logger*/)
        {
          //  this.logger = logger;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok("alguma coisa");
        }
    }
}
