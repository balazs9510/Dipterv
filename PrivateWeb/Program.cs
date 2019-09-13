using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using PrivateWeb.Helpers;
using System.Threading.Tasks;

namespace PrivateWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MapperHelper.InitializeMapper();
            CreateWebHostBuilder(args).Build().Run();
        }

        //public static async Task Main(string[] args)
        //{
        //    (await CreateWebHostBuilder(args)
        //        .Build()
        //        .MigrateDatabase<BookingSystemDbContext>())
        //        .Run();
        //}

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
