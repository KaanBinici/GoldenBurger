using GoldenBurger.DATA.Concrete;
using GoldenBurger.DATA.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Mapping
{
    public class ExtraConfig : IEntityTypeConfiguration<Extra>
    {
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            builder.HasOne(x => x.Basket).WithMany(x => x.extras).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(new Extra
            {
                ID = 1,
                Name = "Çikolatalı Cookie",
                Price = 18,
                ExtraProductName = ExtraProductName.Atıstirmalik,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\cikolatali-cookie.png",
            });
            builder.HasData(new Extra
            {
                ID = 2,
                Name = "Sufle",
                Price = 22,
                ExtraProductName = ExtraProductName.Atıstirmalik,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\sufle.png",
            });
            builder.HasData(new Extra
            {
                ID = 3,
                Name = "Vişneli Tatlı",
                Price = 28,
                ExtraProductName = ExtraProductName.Atıstirmalik,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\visneli-tatli.png",

            });
            builder.HasData(new Extra
            {
                ID = 4,
                Name = "Elmalı Tatlı",
                Price = 25,
                ExtraProductName = ExtraProductName.Atıstirmalik,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\elmali-tatli.png",

            });
            builder.HasData(new Extra
            {
                ID = 5,
                Name = "Mini Sundea",
                Price = 20,
                ExtraProductName = ExtraProductName.Atıstirmalik,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\mini-sundae.png",

            });
            builder.HasData(new Extra
            {
                ID = 6,
                Name = "Mini Acı Sos",
                Price = 8,
                ExtraProductName = ExtraProductName.Sos,
                BasketId = 1,
                Visible=true,
                PhotoPath = "MenusPictures\\mini-aci-sos.png",
            });
            builder.HasData(new Extra
            {
                ID = 7,
                Name = "Mini Ranch",
                Price = 6,
                ExtraProductName = ExtraProductName.Sos,
                BasketId = 1,
                Visible=true,
                PhotoPath = "MenusPictures\\mini-ranch.png",
            });
            builder.HasData(new Extra
            {
                ID = 8,
                Name = "Mini Ketçap",
                Price = 5,
                ExtraProductName = ExtraProductName.Sos,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\mini-ketcap.png",
            });
            builder.HasData(new Extra
            {
                ID = 9,
                Name = "Mini Mayonez",
                Price = 5,
                ExtraProductName = ExtraProductName.Sos,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\mini-mayonez.png",
            });
            builder.HasData(new Extra
            {
                ID = 10,
                Name = "Mini Bbq",
                Price = 6,
                ExtraProductName = ExtraProductName.Sos,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\mini-bbq.png",
            });
            builder.HasData(new Extra
            {
                ID = 11,
                Name = "Mini Ballı Hardal",
                Price = 9,
                ExtraProductName = ExtraProductName.Sos,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\mini-balli-hardal-1.png",
            });
            builder.HasData(new Extra
            {
                ID = 12,
                Name = "Mini Buffalo",
                Price = 8,
                ExtraProductName = ExtraProductName.Sos,
                BasketId = 1,
                Visible = true,
                PhotoPath = "MenusPictures\\mini-buffalo-1.png",
            });

        }
    }
}
