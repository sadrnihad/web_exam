using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace web_exam.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            //_signInManager = signInManager;
        }

        


        


        public IActionResult Index()
        {
            return View();
        }
    }
}
