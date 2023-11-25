using CloudCustomers.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        private readonly IUsersService _userService;
        public UsersController(IUsersService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetAllUsers();
            if(!result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
