using IdentityDemo.Models;
using IdentityDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace IdentityDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthService _authService;

        public UserController(IAuthService authService) 
        {
            _authService = authService;
        }

        // POST: UserController/Register
        [HttpPost]
        public async Task<ActionResult<string>> RegisterUser(User user)
        {
            try
            {
                string response = await _authService.RegisterUser(user);
                Console.WriteLine(response);
                return response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
    }
}
