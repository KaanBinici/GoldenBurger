using System.ComponentModel.DataAnnotations;

namespace GoldenBurger.UI.Models.Vm_s
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email Adresi Zorunludur.")]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; } = false;
    }
}
