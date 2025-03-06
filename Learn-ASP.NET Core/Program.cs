
using Learn_ASP.NET_Core.Data;
using Learn_ASP.NET_Core.MiddelWares;
using Learn_ASP.NET_Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Learn_ASP.NET_Core
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
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(builder => builder.UseSqlServer("Data Source=WAFAA;Initial Catalog=MARKET;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));
           // builder.Services.AddSingleton<IWeatherForcastSevices,WeatherForcastSevices>(); // create a single instance of the service for the entire application


            // create instance form Weatherservice which implement IWeatherForcastSevices for each request
            builder.Services.AddScoped<IWeatherForcastSevices, WeatherForcastSevices>(); // create a new instance of the service for each request 


         //   builder.Services.AddTransient<IWeatherForcastSevices, WeatherForcastSevices>(); // create a new instance of the service for each request in different places in the application

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<RateLimittingMiddelWare>();   

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseMiddleware<ProfillingMiddelWares>();
            app.MapControllers();

            app.Run();
        }
    }
}
