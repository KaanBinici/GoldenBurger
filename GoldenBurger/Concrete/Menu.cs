using GoldenBurger.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.Concrete
{
    public class Menu : Product
    {

        public List<Burger> Burger { get; set; }
        public List<Chips> Chips { get; set; }
        public List<Drink> Drink { get; set; }


    }
}
