using System.Data;
using Webshop.Core.Repositories;
using Webshop.Core.Services;
using Webshop.Infrastructure;
using Webshop.Infrastructure.Repositories;

namespace Webshop.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
            builder.Services.AddScoped<IReceiptRepository, ReceiptRepository>();
            builder.Services.AddScoped<IDbConnection, TestDbConnection>();

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
