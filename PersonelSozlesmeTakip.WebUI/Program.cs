using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.BL.Concreate;
using PersonelSozlesmeTakip.DAL.Context;
using PersonelSozlesmeTakip.Repositories.Abstract;
using PersonelSozlesmeTakip.Repositories.Concreate;

namespace PersonelSozlesmeTakip.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<PersonelSozlesmeContext>(options => options.UseSqlServer("Server=DESKTOP-BODOH2U\\SA; Database=UniDb; uid=sa; pwd=1234;"));


            builder.Services.AddScoped<IUniversityService, UniversityService>();
            builder.Services.AddScoped<IPersonelService, PersonelService>();


            builder.Services.AddScoped<IUniversityRepository, UniversityRepository>();
            builder.Services.AddScoped<IPersonelRepository, PersonelRepository>();
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}