using System.Data;
using LegacyCode.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LegacyCode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUser(string username)
        {
            var user = await _userRepository.GetUserByUsername(username);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            return Ok("Hello" + user.Name);
        }

    }
}
