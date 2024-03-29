using GoldenBurger.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Mapping
{
    public class BasketConfig : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasData(new Basket
            {
                ID = 1,
                SepetAdi="ilkSepet",
                Price=0,
                Visible=false,
                 
            });
        }
    }
}
