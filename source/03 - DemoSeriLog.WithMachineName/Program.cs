using Serilog;
using System;
using System.Globalization;

namespace DemoSeriLog.WithMachineName
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentUserName()
                .WriteTo.Console(
                        formatProvider: new CultureInfo("pt-BR"),
                        outputTemplate: "{Timestamp:HH:mm:ss} [{Level}] (Blablablá - ServerName: {MachineName} - UserName: {EnvironmentUserName})"
                        //github.com/serilog/serilog/wiki/Formatting-Output
                )
                .CreateLogger();


            Log.Information("Hello again, Serilog!");

            Console.ReadLine();
        }
    }
}
