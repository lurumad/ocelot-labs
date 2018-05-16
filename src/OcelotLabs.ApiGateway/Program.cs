using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OcelotLabs.ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var builder = WebHost.CreateDefaultBuilder(args);
            builder
                .ConfigureServices(s => s.AddSingleton(builder))
                .ConfigureAppConfiguration(c =>
                {
                    c.AddJsonFile("ocelot.json", optional: false);
                })
                .UseStartup<Startup>();
            return builder;
        }
    }
}
