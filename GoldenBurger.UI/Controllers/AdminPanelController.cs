using GoldenBurger.Abstracts;
using GoldenBurger.Concrete;
using GoldenBurger.DATA.Concrete;
using GoldenBurger.SERVICE.Concrete;
using GoldenBurger.SERVICE.Interfaces;
using GoldenBurger.UI.Models.Vm_s;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace GoldenBurger.UI.Controllers
{
    public class AdminPanelController : Controller
    {
        private Menu _menuE;
        private readonly IDrinkSERVICE _drinkService;
        private readonly IChipsSERVICE _chipsService;
        private readonly IBasketSERVICE _basketService;
        private readonly IMenuSERVICE _menuService;
        private readonly IExtraSERVICE _extraService;
        private readonly IBurgerSERVICE _burgerSERVICE;
        private readonly IIngredientSERVICE _ingredientService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;
        public AdminPanelController(IMenuSERVICE menuService, IBasketSERVICE basketService, IDrinkSERVICE drinkService, IChipsSERVICE chipsSERVICE, IExtraSERVICE extraService, IBurgerSERVICE burgerSERVICE, IIngredientSERVICE ingredientService, UserManager<IdentityUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _chipsService = chipsSERVICE;
            _basketService = basketService;
            _menuService = menuService;
            _drinkService = drinkService;
            _extraService = extraService;
            _burgerSERVICE = burgerSERVICE;
            _webHostEnvironment = webHostEnvironment;
            _ingredientService = ingredientService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            AdminPanelVM adminPanelVM = new AdminPanelVM();
            var Sepetler = _basketService.GetWhere(x=>x.Visible==true);
            adminPanelVM.SepetSayisi = Sepetler.Count;
            double ToplamCiro = 0;
            foreach (var s in Sepetler)
            {
                ToplamCiro += s.Price;
            }
            adminPanelVM.SepetlerinToplamCirosu = ToplamCiro;
            var users = await _userManager.Users.ToListAsync();
            adminPanelVM.KullaniciSayisi = users.Count;
            adminPanelVM.Users = users;
            var tM = _menuService.GetWhere(x=>x.Visible==true).Count;
            var tB = _burgerSERVICE.GetWhere(x => x.Visible == true).Count;
            var tC = _chipsService.GetWhere(x => x.Visible == true).Count;
            var tD = _drinkService.GetWhere(x => x.Visible == true).Count;
            var tX = _extraService.GetWhere(x => x.Visible == true).Count;
            var toplam = tM+tB+tC+tD+tX;
            adminPanelVM.SergilenenUrunSayisi = toplam;
            return View(adminPanelVM);
        }

        public IActionResult Tables()
        {
            var Menuler = _menuService.GetAll();
            var Burgerler = _burgerSERVICE.GetAll();
            var Extralar = _extraService.GetAll();
            var Patatesler = _chipsService.GetAll();
            var Icecekler = _drinkService.GetAll();
            var Icerikler = _ingredientService.GetAll();
            AllVM allVM = new AllVM()
            {
                Burgers = Burgerler,
                Menus = Menuler,
                Extras = Extralar,
                Chips = Patatesler,
                Drinks = Icecekler,
                Ingredients = Icerikler,
            };

            return View(allVM);
        }

        static Menu menuE;
        public IActionResult MenuEdit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                menuE = _menuService.GetById(id);
                return View(menuE);
            }

        }

        [HttpPost]
        public IActionResult MenuEdit(Menu menu1, IFormFile file)
        {
            if (menuE != null && menuE.ID != null)
            {
                menuE.Name = menu1.Name;
                menuE.Price = menu1.Price;
                menuE.Visible = menu1.Visible;
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() +file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    menuE.PhotoPath = "MenusPictures\\"+FileName;
                }


                _menuService.Update(menuE);
                menuE = null;
                return RedirectToAction("Tables");
            }
            else
            {
                if (file != null && file.Length > 0)
                {

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;

                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    menu1.PhotoPath = "MenusPictures\\" + uniqueFileName;
                }
                menu1.BasketId = 1;
                _menuService.Add(menu1);
                return RedirectToAction("Tables");
            }
        }
        public IActionResult MenuDelete(int id)
        {
            var menu = _menuService.GetById(id);
            _menuService.Delete(menu);
            return RedirectToAction("Tables");

        }

        static Burger burgerE;
        public IActionResult BurgerEdit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                burgerE = _burgerSERVICE.GetById(id);
                return View(burgerE);
            }

        }

        [HttpPost]
        public IActionResult BurgerEdit(Burger burger1, IFormFile file)
        {
            if (burgerE != null && burgerE.ID != null)
            {
                burgerE.Name = burger1.Name;
                burgerE.Price = burger1.Price;
                burgerE.Visible = burger1.Visible;
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    burgerE.PhotoPath = "MenusPictures\\" + FileName;
                }
                _burgerSERVICE.Update(burgerE);
                burgerE = null;
                return RedirectToAction("Tables");
            }
            else
            {
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    burger1.PhotoPath = "MenusPictures\\" + FileName;
                }
                burger1.MenuId = 1;
                burger1.BasketId = 1;
                _burgerSERVICE.Add(burger1);
                return RedirectToAction("Tables");
            }
        }

        public IActionResult BurgerDelete(int id)
        {
            var burger = _burgerSERVICE.GetById(id);
            _burgerSERVICE.Delete(burger);
            return RedirectToAction("Tables");
        }

        static Chips chipsE;
        public IActionResult ChipsEdit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                chipsE = _chipsService.GetById(id);
                return View(chipsE);
            }
        }
        [HttpPost]
        public IActionResult ChipsEdit(Chips chips1, IFormFile file)
        {
            if (chipsE != null && chipsE.ID != null)
            {
                chipsE.Name = chips1.Name;
                chipsE.Price = chips1.Price;
                chipsE.Visible = chips1.Visible;
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    chipsE.PhotoPath = "MenusPictures\\" + FileName;
                }
                _chipsService.Update(chipsE);
                chipsE = null;
                return RedirectToAction("Tables");
            }
            else
            {
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    chips1.PhotoPath = "MenusPictures\\" + FileName;
                }
                chips1.MenuId = 1;
                chips1.BasketId = 1;
                _chipsService.Add(chips1);
                return RedirectToAction("Tables");
            }
        }

        public IActionResult ChipsDelete(int id)
        {
            var chips = _chipsService.GetById(id);
            _chipsService.Delete(chips);

            return RedirectToAction("Tables");
        }

        static Drink drinkE;
        public IActionResult DrinkEdit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                drinkE = _drinkService.GetById(id);
                return View(drinkE);
            }

        }
        [HttpPost]
        public IActionResult DrinkEdit(Drink drink1, IFormFile file)
        {
            if (drinkE != null && drinkE.ID != null)
            {
                drinkE.Name = drink1.Name;
                drinkE.Price = drink1.Price;
                drinkE.Visible = drink1.Visible;
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    drinkE.PhotoPath = "MenusPictures\\" + FileName;
                }
                _drinkService.Update(drinkE);
                drinkE = null;
                return RedirectToAction("Tables");
            }
            else
            {
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    drink1.PhotoPath = "MenusPictures\\" + FileName;
                }
                drink1.MenuId = 1;
                drink1.BasketId = 1;
                _drinkService.Add(drink1);
                return RedirectToAction("Tables");
            }
        }

        public IActionResult DrinkDelete(int id)
        {
            var drink = _drinkService.GetById(id);
            _drinkService.Delete(drink);
            return RedirectToAction("Tables");
        }

        static Extra extraE;
        public IActionResult ExtraEdit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                extraE = _extraService.GetById(id);
                return View(extraE);
            }

        }
        [HttpPost]
        public IActionResult ExtraEdit(Extra extra1, IFormFile file)
        {
            if (extraE != null && extraE.ID != null)
            {
                extraE.Name = extra1.Name;
                extraE.Price = extra1.Price;
                extraE.Visible = extra1.Visible;
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    extraE.PhotoPath = "MenusPictures\\" + FileName;
                }
                _extraService.Update(extraE);
                return RedirectToAction("Tables");
            }
            else
            {
                if (file != null && file.Length > 0)
                {

                    string FileName = Guid.NewGuid().ToString() + file.FileName;

                    string saveFolder = Path.Combine(_webHostEnvironment.WebRootPath, "MenusPictures");
                    string filePath = Path.Combine(saveFolder, FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    extra1.PhotoPath = "MenusPictures\\" + FileName;
                }
                
                extra1.BasketId = 1;
                _extraService.Add(extra1);
                return RedirectToAction("Tables");
            }
        }

        public IActionResult ExtraDelete(int id)
        {
            var extra = _extraService.GetById(id);
            _extraService.Delete(extra);

            return RedirectToAction("Tables");
        }
        public IActionResult NewProduct()
        {
            return View();

        }
        [HttpPost]
        public IActionResult NewProduct(string Secim)
        {
            switch (Secim)
            {
                case "menu":
                    return RedirectToAction("MenuEdit");
                case "burger":
                    return RedirectToAction("BurgerEdit");
                case "patates":
                    return RedirectToAction("ChipsEdit");
                case "icecek":
                    return RedirectToAction("DrinkEdit");
                case "tatlisos":
                    return RedirectToAction("ExtraEdit");
                default:
                    break;
            }
            return View();

        }
    }
}
