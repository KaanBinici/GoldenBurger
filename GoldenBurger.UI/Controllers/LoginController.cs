using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GoldenBurger.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginControl(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                //ViewBag.Message = "Invalid email or password.";
                return View("Index");
            }

            var result = await _signInManager.PasswordSignInAsync(user, password, false, false);

            if (!result.Succeeded)
            {
                //ViewBag.Message = "Invalid email or password.";
                return View("Index");
            }

            Response.Cookies.Append("username", user.Email);
            return RedirectToAction("Index", "Anasayfa");
        }

        public IActionResult SignOut()
        {

            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            ViewBag.WelcomeMessage = null;

            return RedirectToAction("Index", "AnaSayfa");
        }

        //public async Task<bool> IsUserAdmin(string userId)
        //{

        //    var user = await _userManager.FindByIdAsync(userId);


        //    return await _userManager.IsInRoleAsync(user, "Admin");
        //}
    }
}


