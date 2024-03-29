using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace GoldenBurger.UI.Models.Vm_s
{
    public class AdminPanelVM
    {
        public int SepetSayisi { get; set; }
        public double SepetlerinToplamCirosu { get; set; }
        public int KullaniciSayisi { get; set; }
        public int SergilenenUrunSayisi { get; set; }
        public List<IdentityUser> Users { get; set; }
    }
}
    