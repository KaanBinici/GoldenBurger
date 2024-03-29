using GoldenBurger.Concrete;
using GoldenBurger.SERVICE.Concrete;
using GoldenBurger.SERVICE.Interfaces;
using GoldenBurger.UI.Models.Vm_s;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace GoldenBurger.UI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IDrinkSERVICE _drinkService;
        private readonly IChipsSERVICE _chipsService;
        private readonly IBasketSERVICE _basketService;
        private readonly IMenuSERVICE _menuService;
        private readonly IExtraSERVICE _extraService;
        private readonly IBurgerSERVICE _burgerSERVICE;
        private readonly IIngredientSERVICE _ingredientService;
        public BasketController(IMenuSERVICE menuService, IBasketSERVICE basketService, IDrinkSERVICE drinkService, IChipsSERVICE chipsSERVICE, IExtraSERVICE extraService, IBurgerSERVICE burgerSERVICE, IIngredientSERVICE ingredientService)
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
            if (Request.Cookies["Username"] == null)
            {

              return  RedirectToAction("Index","Login");
            }
            else
            {
                string username = Request.Cookies["Username"].ToString();
                var SonSepetId = _basketService.GetWhere(x => x.SepetAdi.Equals(username)).Max(x => x.ID);
                var Menuler = _menuService.GetWhere(x => x.BasketId == SonSepetId);
                var Burgerler = _burgerSERVICE.GetWhere(x => x.BasketId == SonSepetId);
                var Extralar = _extraService.GetWhere(x => x.BasketId == SonSepetId);
                var Patatesler = _chipsService.GetWhere(x => x.BasketId == SonSepetId);
                var Icecekler = _drinkService.GetWhere(x => x.BasketId == SonSepetId);
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

           
        }
        [HttpPost]
        public IActionResult Remove(int foodId, string foodType)
        {
            switch (foodType)
            {
                case "Burger":
                    var burger = _burgerSERVICE.GetById(foodId);
                    if (burger != null)
                    {
                        _burgerSERVICE.Delete(burger);
                    }
                    break;
                case "Menu":

                    var menu = _menuService.GetById(foodId);
                    if (menu != null)
                    {
                        _menuService.Delete(menu);
                    }
                    break;
                case "Drink":

                    var drink = _drinkService.GetById(foodId);
                    if (drink != null)
                    {
                        _drinkService.Delete(drink);
                    }
                    break;
                case "Chips":

                    var chips = _chipsService.GetById(foodId);
                    if (chips != null)
                    {
                        _chipsService.Delete(chips);
                    }
                    break;
                case "Extra":

                    var extra = _extraService.GetById(foodId);
                    if (extra != null)
                    {
                        _extraService.Delete(extra);
                    }
                    break;

                default:

                    break;
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Checkout(string totalPrice)
        {
            double totalPriceDouble = Double.Parse(totalPrice, CultureInfo.InvariantCulture);
            string username = Request.Cookies["Username"].ToString();
            var KullaniciEnSonSepetIDSorgu = (_basketService.GetWhere(x => x.SepetAdi.Equals(username)).Max(x => x.ID));
            var sonSepet = _basketService.GetById(KullaniciEnSonSepetIDSorgu);
            sonSepet.Price = totalPriceDouble;
            sonSepet.Visible = true;
            _basketService.Update(sonSepet);
            var basket = new Basket { SepetAdi = username };
            _basketService.Add(basket);
            TempData["SayiTutucu"] = 0;
            return RedirectToAction("Index", "Anasayfa");
        }

    }
}
