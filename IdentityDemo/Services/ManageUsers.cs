using IdentityDemo.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Services
{
    public class ManageUsers : IAuthService
    {
        private readonly UserManager<User> _userManager;

        public ManageUsers(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> RegisterUser ( User user)
        {
            try
            {
                var result = await _userManager.CreateAsync (user);
                if (result.Succeeded)
                {
                    Console.WriteLine("New User added");
                    return string.Empty;
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
