using GoldenBurger.UI.Models.Vm_s;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace GoldenBurger.UI.Controllers
{
    public class CreateController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public CreateController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email,  };
                
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    Random random = new Random();

                   string onayKodu = random.Next(100000, 999999).ToString();
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("LezzetVirtuozu@outlook.com", "GoldenBurger");
                    mail.To.Add(model.Email);
                    mail.Subject = "Golden Burger Doğrulama Kodu";
                    mail.IsBodyHtml = true;
                    mail.Body = "Golden Burger uygulamasına hoş geldin. İşte Doğrulama Kodun=" + onayKodu;

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp.outlook.com";
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential("LezzetVirtuozu@outlook.com", "lezzet123");

                    smtpClient.Send(mail);
                    smtpClient.Timeout = 100;
                    EmailVerificationVM emailVerificationVM = new EmailVerificationVM();
                    TempData["VerificationUser"]= model.Email;
                    TempData["VerificationCode"]= onayKodu;
                    TempData["VerificationCodeTime"]= DateTime.Now.AddMinutes(2);
                    return RedirectToAction("Verification");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Code + " - " + error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Verification()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Verification(int sayi1, int sayi2, int sayi3, int sayi4, int sayi5, int sayi6)
        {
            var UserEmailbag = TempData["VerificationUser"];
            var user = await _userManager.FindByEmailAsync((string)UserEmailbag);
            string VeriCode = sayi1.ToString() + sayi2.ToString() + sayi3.ToString() + sayi4.ToString() + sayi5.ToString() + sayi6.ToString();
            var VeriCodeBag =(string)TempData["VerificationCode"];
            var VeriCodeTimeBag=(DateTime)TempData["VerificationCodeTime"];
            if (VeriCode==VeriCodeBag && VeriCodeTimeBag > DateTime.Now)
            {
                TempData.Remove("VerificationUser");
                TempData.Remove("VerificationCode");
                TempData.Remove("VerificationCodeTime");
                TempData["Tebrikler"] = "Kaydınız Başarıyla Gerçekleşti.";
                return RedirectToAction("Index","Login");
            }
            else
            {
                TempData.Remove("VerificationUser");
                TempData.Remove("VerificationCode");
                TempData.Remove("VerificationCodeTime");
                var result = await _userManager.DeleteAsync(user);
            }
           
            return View();
        }
        [HttpPost]
        public IActionResult RegisterSuccess()
        {
            return View();
        }
    }
}
