using IdentityDemo.Models;

namespace IdentityDemo.Services
{
    public interface IAuthService
    {
        public Task <string> RegisterUser(User user);
    }
}
