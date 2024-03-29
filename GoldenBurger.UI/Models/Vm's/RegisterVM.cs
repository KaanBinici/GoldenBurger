using System.ComponentModel.DataAnnotations;

namespace GoldenBurger.UI.Models.Vm_s
{
    public class RegisterVM
    {
        //[Required(ErrorMessage = "İsim Alanı Boş Geçilemez.")]
        //public string Name { get; set; }

        //[Required(ErrorMessage = "Soyisim Alanı Boş Geçilemez.")]
        //public string Surname { get; set; }

        [Required(ErrorMessage = "Email Adresi Zorunludur.")]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Şifreler Tutarsız")]
        public string ConfirmPassword { get; set; }
    }
}
