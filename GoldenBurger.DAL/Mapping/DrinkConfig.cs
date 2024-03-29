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
    public class DrinkConfig : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.HasOne(x => x.Menu).WithMany(x => x.Drink).HasForeignKey(x=>x.MenuId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(x => x.Basket).WithMany(x => x.drinks).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Drink
            {
                ID = 1,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 1,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 2,
                Name = "Coca Cola Light",
                Price = 23,
                MenuId = 2,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\coca-cola-light.png",

            });
            builder.HasData(new Drink
            {
                ID = 3,
                Name = "Coca Cola Zero Sugar",
                Price = 23,
                MenuId = 3,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\coca-cola-zero-sugar.png",

            });
            builder.HasData(new Drink
            {
                ID = 4,
                Name = "Fuse Tea",
                Price = 20,
                MenuId = 4,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\fuse-tea.png",
            });
            builder.HasData(new Drink
            {
                ID = 5,
                Name = "Fanta",
                Price = 22,
                MenuId = 5,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\fanta.png",
            });
            builder.HasData(new Drink
            {
                ID = 6,
                Name = "Sprite",
                Price = 24,
                MenuId = 6,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\sprite.png",
            });
            builder.HasData(new Drink
            {
                ID = 7,
                Name = "Ayran 300 ml",
                Price = 30,
                MenuId = 7,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\ayran-300-ml.png",
            });
            builder.HasData(new Drink
            {
                ID = 8,
                Name = "Ayran 195 ml",
                Price = 20,
                MenuId = 8,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\ayran-195-ml.png",
            });
            builder.HasData(new Drink
            {
                ID = 9,
                Name = "Elma Suyu",
                Price = 16,
                MenuId = 9,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\elma-suyu.png",
            });
            builder.HasData(new Drink
            {
                ID = 10,
                Name = "Cappy Atom",
                Price = 18,
                MenuId = 10,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\cappy-atom-200-ml.png",
            });
            builder.HasData(new Drink
            {
                ID = 11,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 11,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 12,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 12,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 13,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 13,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 14,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 14,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 15,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 15,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 16,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 16,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 17,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 17,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 18,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 18,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 19,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 19,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 20,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 20,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 21,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 21,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
            builder.HasData(new Drink
            {
                ID = 22,
                Name = "Coca Cola",
                Price = 25,
                MenuId = 22,
                BasketId = 1,
                Visible = false,
                PhotoPath = "MenusPictures\\coca-cola.png",
            });
        }
    }
}
