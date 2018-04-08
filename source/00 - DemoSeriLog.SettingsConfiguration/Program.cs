using System;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace DemoSeriLog.SettingsConfiguration
{
    //P/ AppSettings no Console:
    //docs.microsoft.com/pt-br/aspnet/core/fundamentals/configuration/index?tabs=basicconfiguration

    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            logger.Information("Hello, world!");


            Console.ReadLine();
        }
    }
}
