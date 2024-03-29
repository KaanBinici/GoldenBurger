using GoldenBurger.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.Concrete
{
    public class Ingredient : Product
    {
        public int BurgerId { get; set; }

        public Burger Burger { get; set; }
    }
}
