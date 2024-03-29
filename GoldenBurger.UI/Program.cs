using GoldenBurger.DAL.Contexts;
using GoldenBurger.SERVICE.Concrete;
using GoldenBurger.SERVICE.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace GoldenBurger.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddScoped<IMenuSERVICE, MenuSERVICE>();
            builder.Services.AddScoped<IBasketSERVICE, BasketSERVICE>();
            builder.Services.AddScoped<IChipsSERVICE, ChipsSERVICE>();
            builder.Services.AddScoped<IDrinkSERVICE, DrinkSERVICE>();
            builder.Services.AddScoped<IExtraSERVICE, ExtraSERVICE>();
            builder.Services.AddScoped<IBurgerSERVICE, BurgerSERVICE>();
            builder.Services.AddScoped<IIngredientSERVICE, IngredientSERVICE>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<GoldenBurgerContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn"))) ;

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_.@";
            })
               .AddEntityFrameworkStores<GoldenBurgerContext>()
               .AddDefaultTokenProviders().AddRoles<IdentityRole>();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login"; //Giriþ yapýlacak sayfa
                options.LogoutPath = "/Account/Logout";
                options.SlidingExpiration = true; //oturum süresi uzatýlsýn mý?
                options.ExpireTimeSpan = TimeSpan.FromDays(14);

            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default2",
               pattern: "{controller=AnaSayfa}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}