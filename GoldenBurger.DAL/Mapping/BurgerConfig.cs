using GoldenBurger.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Mapping
{
    public class BurgerConfig : IEntityTypeConfiguration<Burger>
    {
        public void Configure(EntityTypeBuilder<Burger> builder)
        {
            builder.HasOne(x => x.Menu).WithMany(x => x.Burger).HasForeignKey(x => x.MenuId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Basket).WithMany(x => x.burgers).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Burger
            {
                ID = 1,
                Name = "Big King Jr.",
                Price = 189,
                PhotoPath = "MenusPictures\\big-king-jr-menu.png",
                MenuId = 1,
                BasketId = 1,
                Visible = true,

            });
            builder.HasData(new Burger
            {
                ID = 2,
                Name = "SteakHouse Burger",
                Price = 169,
                PhotoPath = "MenusPictures\\bk-steakhouse-burger-menu.png",
                MenuId = 2,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 3,
                Name = "Cheese Burger",
                Price = 145,
                PhotoPath = "MenusPictures\\cheeseburger-menu.png",
                MenuId = 3,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 4,
                Name = "Double Big King",
                Price = 120,
                PhotoPath = "MenusPictures\\double-big-king-menu.png",
                MenuId = 4,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 5,
                Name = "Double Cheeseburger",
                Price = 109,
                PhotoPath = "MenusPictures\\double-cheeseburger-menu.png",
                MenuId = 5,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 6,
                Name = "Double King Chicken",
                Price = 119,
                PhotoPath = "MenusPictures\\double-king-chicken-menu.png",
                MenuId = 6,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 7,
                Name = "Double Köfte Burger",
                Price = 129,
                PhotoPath = "MenusPictures\\double-kofteburger-menu.png",
                MenuId = 7,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 8,
                Name = "Double Whopper Jr.",
                Price = 135,
                PhotoPath = "MenusPictures\\double-whopper-jr-menu.png",
                MenuId = 8,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 9,
                Name = "Double Whopper",
                Price = 155,
                PhotoPath = "MenusPictures\\double-whopper-menu.png",
                MenuId = 9,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 10,
                Name = "Etli Barbekü Deluxe Burger",
                Price = 169,
                PhotoPath = "MenusPictures\\etli-barbeku-deluxe-burger-menu.png",
                MenuId = 10,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 11,
                Name = "King Beef Burger",
                Price = 159,
                PhotoPath = "MenusPictures\\king-beef-burger-menu.png",
                MenuId = 11,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 12,
                Name = "King Chicken",
                Price = 99,
                PhotoPath = "MenusPictures\\king-chicken-menu.png",
                MenuId = 12,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 13,
                Name = "Köfte Burger",
                Price = 119,
                PhotoPath = "MenusPictures\\kofteburger-menu.png",
                MenuId = 13,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 14,
                Name = "Mega Double Cheeseburger",
                Price = 149,
                PhotoPath = "MenusPictures\\mega-double-cheeseburger-menu.png",
                MenuId = 14,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 15,
                Name = "Plant Based Whopper",
                Price = 129,
                PhotoPath = "MenusPictures\\plant-based-whopper-menu.png",
                MenuId = 15,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 16,
                Name = "Rodeo Whopper",
                Price = 134,
                PhotoPath = "MenusPictures\\rodeo-whopper-menu.png",
                MenuId = 16,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 17,
                Name = "Tavuklu Barbekü Brioche",
                Price = 115,
                PhotoPath = "MenusPictures\\tavuklu-barbeku-brioche-menu.png",
                MenuId = 17,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 18,
                Name = "Texas SmokeHouse Burger",
                Price = 150,
                PhotoPath = "MenusPictures\\texas-smokehouse-burger-menu.png",
                MenuId = 18,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 19,
                Name = "Triple Whopper",
                Price = 145,
                PhotoPath = "MenusPictures\\triple-whopper-menu.png",
                MenuId = 19,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 20,
                Name = "Trüflü King Beef Burger",
                Price = 135,
                PhotoPath = "MenusPictures\\truflu-king-beef-burger-menu.png",
                MenuId = 20,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 21,
                Name = "Whopper Jr.",
                Price = 99,
                PhotoPath = "MenusPictures\\whopper-jr-menu.png",
                MenuId = 21,
                BasketId = 1,
                Visible = true,
            });
            builder.HasData(new Burger
            {
                ID = 22,
                Name = "Whopper",
                Price = 100,
                PhotoPath = "MenusPictures\\whopper-menu.png",
                MenuId = 22,
                BasketId = 1,
                Visible = true,
            });

        }
    }
}
