using GoldenBurger.Concrete;
using GoldenBurger.DAL.Mapping;
using GoldenBurger.DATA.Concrete;
using GoldenBurger.DATA.Enums;
using GoldenBurger.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBurger.DAL.Contexts
{
    public class GoldenBurgerContext : IdentityDbContext<IdentityUser>
    {
        public GoldenBurgerContext(DbContextOptions<GoldenBurgerContext> options) : base(options)
        {
        }


        public DbSet<Menu> Menus { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Chips> Chips { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-6QAKKSF;Database=GoldenBurger;Trusted_Connection=True;TrustServerCertificate=True");
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new BurgerConfig());
            //builder.ApplyConfiguration(new IngredientConfig());
            //builder.ApplyConfiguration(new DrinkConfig());
            //builder.ApplyConfiguration(new ChipsConfig());
            //builder.ApplyConfiguration(new BasketConfig());
            //builder.ApplyConfiguration(new ExtraConfig());
            //builder.ApplyConfiguration(new MenuConfig());
            builder.ApplyConfiguration(new MenuConfig());
            builder.ApplyConfiguration(new ExtraConfig());

            builder.ApplyConfiguration(new BasketConfig());
            builder.ApplyConfiguration(new ChipsConfig());
            builder.ApplyConfiguration(new DrinkConfig());
            builder.ApplyConfiguration(new IngredientConfig());
            builder.ApplyConfiguration(new BurgerConfig());

            var adminRoleId = Guid.NewGuid().ToString();
            base.OnModelCreating(builder);

            // Identity tabloları için konfigürasyon
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "adminRoleId", Name = "admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "userRoleId", Name = "user", NormalizedName = "USER" }
            );

            var hasher = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser
            {
                Id = "adminUserId",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            };

            builder.Entity<IdentityUser>().HasData(adminUser);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "adminRoleId",
                UserId = "adminUserId"
            });

        }

    }
}
