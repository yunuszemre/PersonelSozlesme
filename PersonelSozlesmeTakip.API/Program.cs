using Microsoft.EntityFrameworkCore;
using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.BL.Concreate;
using PersonelSozlesmeTakip.DAL.Context;
using PersonelSozlesmeTakip.Repositories.Abstract;
using PersonelSozlesmeTakip.Repositories.Concreate;

namespace PersonelSozlesmeTakip.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContext<PersonelSozlesmeContext>(options => options.UseSqlServer("Server=DESKTOP-BODOH2U\\SA; Database=UniDb; uid=sa; pwd=1234"));

            builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}