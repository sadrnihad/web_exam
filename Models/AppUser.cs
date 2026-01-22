using Microsoft.AspNetCore.Identity;

namespace web_exam.Models
{
    public class AppUser : IdentityUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
