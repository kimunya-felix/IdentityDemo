using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string OID { get; set; }
        public string Sub { get; set; }
    }
}
