using Microsoft.AspNetCore.Mvc;

namespace GoldenBurger.UI.Controllers
{
    public class AnaSayfaController : Controller
    {
        public IActionResult Index()
        {
            string welcomeMessage = "Giriş Yap";
            if (Request.Cookies["Username"] != null)
            {
                string username = Request.Cookies["Username"].ToString();
                welcomeMessage = $"{username}";
            }
            ViewBag.WelcomeMessage = welcomeMessage;
            TempData["SayiTutucu"] = 0;
            return View();
        }
    }
}
