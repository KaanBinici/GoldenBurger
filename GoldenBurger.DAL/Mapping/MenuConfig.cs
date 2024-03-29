using GoldenBurger.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Mapping
{
    public class MenuConfig : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasOne(x => x.Basket).WithMany(x => x.menus).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(new Menu
            {
                ID = 1,
                Name = "Big King Jr. Menü",
                Price = 219,
                PhotoPath = "MenusPictures\\big-king-jr-menu.png",
                BasketId = 1,

            });
            builder.HasData(new Menu
            {
                ID = 2,
                Name = "SteakHouse Burger Menü",
                Price = 229,
                PhotoPath = "MenusPictures\\bk-steakhouse-burger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 3,
                Name = "Cheese Burger Menü",
                Price = 200,
                PhotoPath = "MenusPictures\\cheeseburger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 4,
                Name = "Double Big King Menü",
                Price = 240,
                PhotoPath = "MenusPictures\\double-big-king-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 5,
                Name = "Double Cheeseburger Menü",
                Price = 235,
                PhotoPath = "MenusPictures\\double-cheeseburger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 6,
                Name = "Double King Chicken Menü",
                Price = 199,
                PhotoPath = "MenusPictures\\double-king-chicken-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 7,
                Name = "Double Köfte Burger Menü",
                Price = 235,
                PhotoPath = "MenusPictures\\double-kofteburger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 8,
                Name = "Double Whopper Jr. Menü",
                Price = 249,
                PhotoPath = "MenusPictures\\double-whopper-jr-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 9,
                Name = "Double Whopper Menü",
                Price = 219,
                PhotoPath = "MenusPictures\\double-whopper-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 10,
                Name = "Etli Barbekü Deluxe Burger Menü",
                Price = 269,
                PhotoPath = "MenusPictures\\etli-barbeku-deluxe-burger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 11,
                Name = "King Beef Burger Menü",
                Price = 280,
                PhotoPath = "MenusPictures\\king-beef-burger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 12,
                Name = "King Chicken Menü",
                Price = 209,
                PhotoPath = "MenusPictures\\king-chicken-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 13,
                Name = "Köfte Burger Menü",
                Price = 216,
                PhotoPath = "MenusPictures\\kofteburger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 14,
                Name = "Mega Double Cheeseburger Menü",
                Price = 230,
                PhotoPath = "MenusPictures\\mega-double-cheeseburger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 15,
                Name = "Plant Based Whopper Menü",
                Price = 250,
                PhotoPath = "MenusPictures\\plant-based-whopper-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 16,
                Name = "Rodeo Whopper Menü",
                Price = 269,
                PhotoPath = "MenusPictures\\rodeo-whopper-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 17,
                Name = "Tavuklu Barbekü Brioche Menü",
                Price = 215,
                PhotoPath = "MenusPictures\\tavuklu-barbeku-brioche-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 18,
                Name = "Texas SmokeHouse Burger Menü",
                Price = 255,
                PhotoPath = "MenusPictures\\texas-smokehouse-burger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 19,
                Name = "Triple Whopper Menü",
                Price = 299,
                PhotoPath = "MenusPictures\\triple-whopper-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 20,
                Name = "Trüflü King Beef Burger Menü",
                Price = 310,
                PhotoPath = "MenusPictures\\truflu-king-beef-burger-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 21,
                Name = "Whopper Jr. Menü",
                Price = 268,
                PhotoPath = "MenusPictures\\whopper-jr-menu.png",
                BasketId = 1,
            });
            builder.HasData(new Menu
            {
                ID = 22,
                Name = "Whopper Menü",
                Price = 236,
                PhotoPath = "MenusPictures\\whopper-menu.png",
                BasketId = 1,
            });
        }
    }
}
