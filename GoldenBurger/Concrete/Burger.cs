using GoldenBurger.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.Concrete
{
    public class Burger : Product
    {
        public Burger()
        {
            Ingredients = new List<Ingredient>();
        }

        public List<Ingredient> Ingredients { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

    }
}
