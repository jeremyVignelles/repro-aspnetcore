using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Repro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var provider = host.Services.GetRequiredService<IApiDescriptionGroupCollectionProvider>();
            foreach (var group in provider.ApiDescriptionGroups.Items)
            {
                foreach (var item in group.Items)
                {
                    Console.WriteLine(item.RelativePath);
                    foreach (var responseType in item.SupportedResponseTypes)
                    {
                        Console.WriteLine($" -- {responseType.StatusCode}");
                    }
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
