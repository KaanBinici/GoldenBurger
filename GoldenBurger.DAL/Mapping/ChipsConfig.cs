using GoldenBurger.Concrete;
using GoldenBurger.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Mapping
{
    public class ChipsConfig : IEntityTypeConfiguration<Chips>
    {
        public void Configure(EntityTypeBuilder<Chips> builder)
        {
            builder.HasOne(x => x.Menu).WithMany(x => x.Chips).HasForeignKey(x => x.MenuId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(x => x.Basket).WithMany(x => x.chips).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Chips
            {
                ID = 1,
                Name = "Patates",
                Price = 34,
                ChipsType = ChipsType.ElmaDilimPatates,
                MenuId = 1,
                BasketId = 1,
                PhotoPath = "MenusPictures\\tirtikli-patates.png",
                Visible = true,
            });
            builder.HasData(new Chips
            {
                ID = 2,
                Name = "Patates",
                Price = 32,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 2,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible= true,
            });
            builder.HasData(new Chips
            {
                ID = 3,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 3,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 4,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 4,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 5,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 5,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 6,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 6,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 7,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 7,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 8,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 8,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 9,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 9,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 10,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 10,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 11,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 11,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 12,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 12,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 13,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 13,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 14,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 14,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 15,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 15,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 16,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 16,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 17,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 17,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 18,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 18,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 19,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 19,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 20,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 20,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 21,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 21,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
            builder.HasData(new Chips
            {
                ID = 22,
                Name = "Patates",
                Price = 25,
                ChipsType = ChipsType.ParmakPatates,
                MenuId = 22,
                BasketId = 1,
                PhotoPath = "MenusPictures\\patates.png",
                Visible = false,
            });
        }
    }
}
