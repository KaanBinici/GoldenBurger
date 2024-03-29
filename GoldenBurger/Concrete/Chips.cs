using GoldenBurger.Abstracts;
using GoldenBurger.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.Concrete
{
    public class Chips : Product
    {
        public ChipsType ChipsType { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        [NotMapped]
        public Size Size { get; set; }
    }
}
