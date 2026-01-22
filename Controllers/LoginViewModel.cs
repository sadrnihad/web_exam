using Microsoft.AspNetCore.Identity;

namespace web_exam.Controllers
{
    public class LoginViewModel
    {
        public IdentityUser Username { get; internal set; }
        public bool RememberMe { get; internal set; }
        public string Password { get; internal set; }
    }
}