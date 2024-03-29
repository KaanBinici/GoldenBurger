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
    public class IngredientConfig : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasOne(x => x.Burger).WithMany(x => x.Ingredients).HasForeignKey(x => x.BurgerId);
            builder.HasOne(x => x.Basket).WithMany(x => x.Ingredients).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(new Ingredient
            {
                ID = 1,
                Name = "Turşu",
                Price = 5.5,
                BurgerId = 1,
                BasketId = 1,

            });
            builder.HasData(new Ingredient
            {
                ID = 2,
                Name = "Domates",
                Price = 7.5,
                BurgerId = 2,
                BasketId = 1,
            });
            builder.HasData(new Ingredient
            {
                ID = 3,
                Name = "Ketçap",
                Price = 6,
                BurgerId = 3,
                BasketId = 1,
            });
            builder.HasData(new Ingredient
            {
                ID = 4,
                Name = "Mayonez",
                Price = 6,
                BurgerId = 1,
                BasketId = 1,
            });
            builder.HasData(new Ingredient
            {
                ID = 5,
                Name = "Hardal",
                Price = 10,
                BurgerId = 1,
                BasketId = 1,
            });
            builder.HasData(new Ingredient
            {
                ID = 6,
                Name = "Marul",
                Price = 12,
                BurgerId = 1,
                BasketId = 1,
            });
        }
    }
}
