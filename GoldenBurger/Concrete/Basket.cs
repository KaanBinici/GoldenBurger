using GoldenBurger.Abstracts;
using GoldenBurger.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.Concrete
{
    public class Basket : BaseEntity
    {
        public int ID { get; set; }
        public string SepetAdi { get; set; }
        public double Price { get; set; }

        public bool? Visible { get; set; } = false;

        public List<Burger> burgers = new List<Burger>();
        public List<Chips> chips = new List<Chips>();
        public List<Drink> drinks = new List<Drink>();
        public List<Extra> extras = new List<Extra>();
        public List<Ingredient> Ingredients = new List<Ingredient>();
        public List<Menu> menus = new List<Menu>();
    }
}
