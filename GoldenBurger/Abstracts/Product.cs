using GoldenBurger.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.Abstracts
{
    [NotMapped]
    public abstract class Product : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? PhotoPath { get; set; }
        public bool? Visible { get; set; } = true;
        public int Count { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
