using GoldenBurger.Abstracts;
using GoldenBurger.Concrete;
using GoldenBurger.DATA.Concrete;
using NuGet.Packaging;

namespace GoldenBurger.UI.Models.Vm_s
{
    public class AllVM
    {
        public List<Menu> Menus { get; set; }
        public List<Burger> Burgers { get; set; }
        public List<Chips> Chips { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<Extra> Extras { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Product> GetAllItemsExceptIngredients()
        {
            var allItems = new List<Product>();

            if (Menus != null && Menus.Any())
            {
                allItems.AddRange(Menus);
            }

            if (Burgers != null && Burgers.Any())
            {
                allItems.AddRange(Burgers);
            }

            if (Chips != null && Chips.Any())
            {
                allItems.AddRange(Chips);
            }

            if (Drinks != null && Drinks.Any())
            {
                allItems.AddRange(Drinks);
            }

            if (Extras != null && Extras.Any())
            {
                allItems.AddRange(Extras);
            }

            return allItems;
        }
    }
}
