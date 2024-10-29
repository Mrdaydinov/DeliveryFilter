using DeliveryFilter.Data;
using DeliveryFilter.Models;
using DeliveryFilter.Repositories;
using DeliveryFilter.Services;
using DeliveryFilter.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace DeliveryFilter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            builder.Configuration.AddEnvironmentVariables();

            var logFilePath = builder.Configuration["Logging:LogFilePath"] ?? Environment.GetEnvironmentVariable("LOG_FILE_PATH") ?? "logs/log-.txt";

            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Information()
                 .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
                 .CreateLogger();

            builder.Host.UseSerilog();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IValidator<Order>, OrderValidator>();

            builder.Services.AddDbContext<DeliveryContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));



            var app = builder.Build();

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
