using Microsoft.AspNetCore.Identity;

namespace GoldenBurger.UI.Models.Vm_s
{
    public class EmailVerificationVM
    {
        public IdentityUser User { get; set; }
        public string VerificationCode { get; set; }
    }
}
