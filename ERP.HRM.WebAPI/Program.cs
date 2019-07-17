using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ERP.HRM.ORM;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ERP.HRM.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //var host = CreateWebHostBuilder(args).Build();

            ////seed

            //using (var scope = host.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;

            //    try
            //    {
            //        var serviceProvider = services.GetRequiredService<IServiceProvider>();
            //        var configration = services.GetRequiredService<IConfiguration>();
            //        DbInitializer.Seed(serviceProvider, configration).Wait();
            //    }
            //    catch (Exception exception)
            //    {
            //        var logger = services.GetRequiredService<ILogger>();
            //        logger.LogError(exception, "An error occurred while creating roles ");
            //    }
            //}

            //host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
