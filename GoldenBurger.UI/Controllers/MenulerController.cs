using GoldenBurger.Concrete;
using GoldenBurger.DATA.Concrete;
using GoldenBurger.Enums;
using GoldenBurger.SERVICE.Concrete;
using GoldenBurger.SERVICE.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography.X509Certificates;

namespace GoldenBurger.UI.Controllers
{

    public class MenulerController : Controller
    {
        public static int SayiTutucu;
        private readonly IDrinkSERVICE _drinkService;
        private readonly IChipsSERVICE _chipsService;
        private readonly IBasketSERVICE _basketService;
        private readonly IMenuSERVICE _menuService;
        private readonly IExtraSERVICE _extraService;
        private readonly IBurgerSERVICE _burgerSERVICE;
        private readonly IIngredientSERVICE _ingredientService;
        public MenulerController(IMenuSERVICE menuService, IBasketSERVICE basketService, IDrinkSERVICE drinkService, IChipsSERVICE chipsSERVICE, IExtraSERVICE extraService, IBurgerSERVICE burgerSERVICE, IIngredientSERVICE ingredientService)
        {
            _chipsService = chipsSERVICE;
            _basketService = basketService;
            _menuService = menuService;
            _drinkService = drinkService;
            _extraService = extraService;
            _burgerSERVICE = burgerSERVICE;
            _ingredientService = ingredientService;
        }
        public IActionResult Index()
        {
            TempData["SayiTutucu"] = SayiTutucu;
            var menus = _menuService.GetWhere(x => x.Visible == true);
            return View(menus);
        }

        [HttpPost]
        public IActionResult SepeteMenuEkle(int productId)
        {
            SayiTutucu += 1;
            string numberAsString = SayiTutucu.ToString();
            //Response.Cookies.Append("MyNumber", numberAsString);

            TempData["SayiTutucu"] = SayiTutucu;

            if (Request.Cookies["Username"] != null)
            {
                string username = Request.Cookies["Username"].ToString();

                var KullaniciEnSonSepetIDSorgu = (_basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList());
                var basketList = _basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList();
                var KullaniciEnSonSepetID = 0;
                if (KullaniciEnSonSepetIDSorgu != null && KullaniciEnSonSepetIDSorgu.Any())
                {
                    KullaniciEnSonSepetID = KullaniciEnSonSepetIDSorgu.Max(x => x.ID);
                }
                else
                {
                    KullaniciEnSonSepetIDSorgu = null;
                }

                var UyeSepetAdedVarMi = _basketService.GetWhere(x => x.SepetAdi.Equals(username) && x.Visible == false).FirstOrDefault();

                if (UyeSepetAdedVarMi == null)
                {
                    var basket = new Basket { SepetAdi = username };
                    _basketService.Add(basket);

                    var IdGoreMenuGetir2 = _menuService.GetWhere(x => x.ID == productId).FirstOrDefault();
                    Menu menu2 = new Menu();
                    menu2.Name = IdGoreMenuGetir2.Name;
                    menu2.Price = IdGoreMenuGetir2.Price;
                    menu2.PhotoPath = IdGoreMenuGetir2.PhotoPath;
                    menu2.Visible = false;
                    if (UyeSepetAdedVarMi == null)
                        menu2.BasketId = KullaniciEnSonSepetID;
                    else
                        menu2.BasketId = UyeSepetAdedVarMi.ID;

                    _menuService.Add(menu2);

                    return Json(new { success = true, message = "Ürün sepete eklendi." });
                }
                var IdGoreMenuGetir = _menuService.GetWhere(x => x.ID == productId).FirstOrDefault();
                Menu menu = new Menu();
                menu.Name = IdGoreMenuGetir.Name;
                menu.Price = IdGoreMenuGetir.Price;
                menu.PhotoPath = IdGoreMenuGetir.PhotoPath;
                menu.Visible = false;
                if (UyeSepetAdedVarMi == null)
                    menu.BasketId = KullaniciEnSonSepetID;
                else
                    menu.BasketId = UyeSepetAdedVarMi.ID;

                _menuService.Add(menu);

                return Json(new { success = true, message = "Ürün sepete eklendi." });

            }
            else
            {
                return RedirectToAction("Index","Login");
            }




        }
        public IActionResult SepeteBurgerEkle(int productId)
        {
            SayiTutucu += 1;
            string numberAsString = SayiTutucu.ToString();
            //Response.Cookies.Append("MyNumber", numberAsString);

            TempData["SayiTutucu"] = SayiTutucu;

            if (Request.Cookies["Username"] != null)
            {
                string username = Request.Cookies["Username"].ToString();

                var KullaniciEnSonSepetIDSorgu = (_basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList());
                var basketList = _basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList();
                var KullaniciEnSonSepetID = 0;
                if (KullaniciEnSonSepetIDSorgu != null && KullaniciEnSonSepetIDSorgu.Any())
                {
                    KullaniciEnSonSepetID = KullaniciEnSonSepetIDSorgu.Max(x => x.ID);
                }
                else
                {
                    KullaniciEnSonSepetIDSorgu = null;
                }

                var UyeSepetAdedVarMi = _basketService.GetWhere(x => x.SepetAdi.Equals(username) && x.Visible == false).FirstOrDefault();

                if (UyeSepetAdedVarMi == null)
                {
                    var basket = new Basket { SepetAdi = username };
                    _basketService.Add(basket);

                    var IdGoreMenuGetir2 = _burgerSERVICE.GetWhere(x => x.ID == productId).FirstOrDefault();
                    Burger menu2 = new Burger();
                    menu2.Name = IdGoreMenuGetir2.Name;
                    menu2.Price = IdGoreMenuGetir2.Price;
                    menu2.PhotoPath = IdGoreMenuGetir2.PhotoPath;
                    menu2.Visible = false;
                    menu2.MenuId = 1;
                    if (UyeSepetAdedVarMi == null)
                        menu2.BasketId = KullaniciEnSonSepetID;
                    else
                        menu2.BasketId = UyeSepetAdedVarMi.ID;

                    _burgerSERVICE.Add(menu2);

                    return Json(new { success = true, message = "Ürün sepete eklendi." });
                }
                var IdGoreMenuGetir = _burgerSERVICE.GetWhere(x => x.ID == productId).FirstOrDefault();
                Burger menu = new Burger();
                menu.Name = IdGoreMenuGetir.Name;
                menu.Price = IdGoreMenuGetir.Price;
                menu.PhotoPath = IdGoreMenuGetir.PhotoPath;
                menu.Visible = false;
                menu.MenuId = 1;
                if (UyeSepetAdedVarMi == null)
                    menu.BasketId = KullaniciEnSonSepetID;
                else
                    menu.BasketId = UyeSepetAdedVarMi.ID;

                _burgerSERVICE.Add(menu);

                return Json(new { success = true, message = "Ürün sepete eklendi." });

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            // Sepete ürün ekleme işlemini gerçekleştir
            // Örneğin:
            // _menuService.AddToBasket(productId);

            // Başarılı bir şekilde eklendiğini belirtmek için uygun bir mesaj döndür
            return Json(new { success = true, message = "Ürün sepete eklendi." });


        }
        public IActionResult SepeteChipsEkle(int productId)
        {
            SayiTutucu += 1;
            string numberAsString = SayiTutucu.ToString();
            //Response.Cookies.Append("MyNumber", numberAsString);

            TempData["SayiTutucu"] = SayiTutucu;

            if (Request.Cookies["Username"] != null)
            {
                string username = Request.Cookies["Username"].ToString();

                var KullaniciEnSonSepetIDSorgu = (_basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList());
                var basketList = _basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList();
                var KullaniciEnSonSepetID = 0;
                if (KullaniciEnSonSepetIDSorgu != null && KullaniciEnSonSepetIDSorgu.Any())
                {
                    KullaniciEnSonSepetID = KullaniciEnSonSepetIDSorgu.Max(x => x.ID);
                }
                else
                {
                    KullaniciEnSonSepetIDSorgu = null;
                }

                var UyeSepetAdedVarMi = _basketService.GetWhere(x => x.SepetAdi.Equals(username) && x.Visible == false).FirstOrDefault();

                if (UyeSepetAdedVarMi == null)
                {
                    var basket = new Basket { SepetAdi = username };
                    _basketService.Add(basket);

                    var IdGoreMenuGetir2 = _chipsService.GetWhere(x => x.ID == productId).FirstOrDefault();
                    Chips menu2 = new Chips();
                    menu2.Name = IdGoreMenuGetir2.Name;
                    menu2.Price = IdGoreMenuGetir2.Price;
                    menu2.PhotoPath = IdGoreMenuGetir2.PhotoPath;
                    menu2.Visible = false;
                    menu2.MenuId = 1;
                    if (UyeSepetAdedVarMi == null)
                        menu2.BasketId = KullaniciEnSonSepetID;
                    else
                        menu2.BasketId = UyeSepetAdedVarMi.ID;

                    _chipsService.Add(menu2);

                    return Json(new { success = true, message = "Ürün sepete eklendi." });
                }
                var IdGoreMenuGetir = _chipsService.GetWhere(x => x.ID == productId).FirstOrDefault();
                Chips menu = new Chips();
                menu.Name = IdGoreMenuGetir.Name;
                menu.Price = IdGoreMenuGetir.Price;
                menu.PhotoPath = IdGoreMenuGetir.PhotoPath;
                menu.Visible = false;
                menu.MenuId = 1;
                if (UyeSepetAdedVarMi == null)
                    menu.BasketId = KullaniciEnSonSepetID;
                else
                    menu.BasketId = UyeSepetAdedVarMi.ID;

                _chipsService.Add(menu);

                return Json(new { success = true, message = "Ürün sepete eklendi." });

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            // Sepete ürün ekleme işlemini gerçekleştir
            // Örneğin:
            // _menuService.AddToBasket(productId);

            // Başarılı bir şekilde eklendiğini belirtmek için uygun bir mesaj döndür
            return Json(new { success = true, message = "Ürün sepete eklendi." });


        }
        public IActionResult SepeteDrinkEkle(int productId)
        {
            SayiTutucu += 1;
            string numberAsString = SayiTutucu.ToString();
            //Response.Cookies.Append("MyNumber", numberAsString);

            TempData["SayiTutucu"] = SayiTutucu;

            if (Request.Cookies["Username"] != null)
            {
                string username = Request.Cookies["Username"].ToString();

                var KullaniciEnSonSepetIDSorgu = (_basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList());
                var basketList = _basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList();
                var KullaniciEnSonSepetID = 0;
                if (KullaniciEnSonSepetIDSorgu != null && KullaniciEnSonSepetIDSorgu.Any())
                {
                    KullaniciEnSonSepetID = KullaniciEnSonSepetIDSorgu.Max(x => x.ID);
                }
                else
                {
                    KullaniciEnSonSepetIDSorgu = null;
                }

                var UyeSepetAdedVarMi = _basketService.GetWhere(x => x.SepetAdi.Equals(username) && x.Visible == false).FirstOrDefault();

                if (UyeSepetAdedVarMi == null)
                {
                    var basket = new Basket { SepetAdi = username };
                    _basketService.Add(basket);

                    var IdGoreMenuGetir2 = _drinkService.GetWhere(x => x.ID == productId).FirstOrDefault();
                    Drink menu2 = new Drink();
                    menu2.Name = IdGoreMenuGetir2.Name;
                    menu2.Price = IdGoreMenuGetir2.Price;
                    menu2.PhotoPath = IdGoreMenuGetir2.PhotoPath;
                    menu2.Visible = false;
                    menu2.MenuId = 1;
                    if (UyeSepetAdedVarMi == null)
                        menu2.BasketId = KullaniciEnSonSepetID;
                    else
                        menu2.BasketId = UyeSepetAdedVarMi.ID;

                    _drinkService.Add(menu2);

                    return Json(new { success = true, message = "Ürün sepete eklendi." });
                }
                var IdGoreMenuGetir = _drinkService.GetWhere(x => x.ID == productId).FirstOrDefault();
                Drink menu = new Drink();
                menu.Name = IdGoreMenuGetir.Name;
                menu.Price = IdGoreMenuGetir.Price;
                menu.PhotoPath = IdGoreMenuGetir.PhotoPath;
                menu.Visible = false;
                menu.MenuId = 1;
                if (UyeSepetAdedVarMi == null)
                    menu.BasketId = KullaniciEnSonSepetID;
                else
                    menu.BasketId = UyeSepetAdedVarMi.ID;

                _drinkService.Add(menu);

                return Json(new { success = true, message = "Ürün sepete eklendi." });

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            // Sepete ürün ekleme işlemini gerçekleştir
            // Örneğin:
            // _menuService.AddToBasket(productId);

            // Başarılı bir şekilde eklendiğini belirtmek için uygun bir mesaj döndür
            return Json(new { success = true, message = "Ürün sepete eklendi." });


        }
        public IActionResult SepeteExtraEkle(int productId)
        {
            SayiTutucu += 1;
            string numberAsString = SayiTutucu.ToString();
            //Response.Cookies.Append("MyNumber", numberAsString);

            TempData["SayiTutucu"] = SayiTutucu;

            if (Request.Cookies["Username"] != null)
            {
                string username = Request.Cookies["Username"].ToString();

                var KullaniciEnSonSepetIDSorgu = (_basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList());
                var basketList = _basketService.GetWhere(x => x.SepetAdi.Equals(username)).ToList();
                var KullaniciEnSonSepetID = 0;
                if (KullaniciEnSonSepetIDSorgu != null && KullaniciEnSonSepetIDSorgu.Any())
                {
                    KullaniciEnSonSepetID = KullaniciEnSonSepetIDSorgu.Max(x => x.ID);
                }
                else
                {
                    KullaniciEnSonSepetIDSorgu = null;
                }

                var UyeSepetAdedVarMi = _basketService.GetWhere(x => x.SepetAdi.Equals(username) && x.Visible == false).FirstOrDefault();

                if (UyeSepetAdedVarMi == null)
                {
                    var basket = new Basket { SepetAdi = username };
                    _basketService.Add(basket);

                    var IdGoreMenuGetir2 = _extraService.GetWhere(x => x.ID == productId).FirstOrDefault();
                    Extra menu2 = new Extra();
                    menu2.Name = IdGoreMenuGetir2.Name;
                    menu2.Price = IdGoreMenuGetir2.Price;
                    menu2.PhotoPath = IdGoreMenuGetir2.PhotoPath;
                    menu2.Visible = false;
                    if (UyeSepetAdedVarMi == null)
                        menu2.BasketId = KullaniciEnSonSepetID;
                    else
                        menu2.BasketId = UyeSepetAdedVarMi.ID;

                    _extraService.Add(menu2);

                    return Json(new { success = true, message = "Ürün sepete eklendi." });
                }
                var IdGoreMenuGetir = _extraService.GetWhere(x => x.ID == productId).FirstOrDefault();
                Extra menu = new Extra();
                menu.Name = IdGoreMenuGetir.Name;
                menu.Price = IdGoreMenuGetir.Price;
                menu.PhotoPath = IdGoreMenuGetir.PhotoPath;
                menu.Visible = false;
                if (UyeSepetAdedVarMi == null)
                    menu.BasketId = KullaniciEnSonSepetID;
                else
                    menu.BasketId = UyeSepetAdedVarMi.ID;

                _extraService.Add(menu);

                return Json(new { success = true, message = "Ürün sepete eklendi." });

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            // Sepete ürün ekleme işlemini gerçekleştir
            // Örneğin:
            // _menuService.AddToBasket(productId);

            // Başarılı bir şekilde eklendiğini belirtmek için uygun bir mesaj döndür
            return Json(new { success = true, message = "Ürün sepete eklendi." });


        }
        public IActionResult Burgers()
        {
            TempData["SayiTutucu"] = SayiTutucu;
            var burger = _burgerSERVICE.GetWhere(x => x.Visible == true);
            return View(burger);
        }
        public IActionResult Chips()
        {
            TempData["SayiTutucu"] = SayiTutucu;
            var chips = _chipsService.GetWhere(x => x.Visible == true);
            return View(chips);
        }
        public IActionResult Drink()
        {
            TempData["SayiTutucu"] = SayiTutucu;
            var drink = _drinkService.GetWhere(x => x.Visible == true);
            return View(drink);
        }
        public IActionResult Extra()
        {
            TempData["SayiTutucu"] = SayiTutucu;
            var extra = _extraService.GetWhere(x => x.Visible == true);
            return View(extra);

        }

        public IActionResult GetIngridientPriceById(int uid)
        {

            var ingredient = _ingredientService.GetWhere(x => x.ID == uid).FirstOrDefault();

            var jsonObject = JsonConvert.SerializeObject(ingredient);

            return Json(jsonObject);

        }
    }
}
