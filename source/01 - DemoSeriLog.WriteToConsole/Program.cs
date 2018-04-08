using Serilog;
using System;

namespace DemoSeriLog.WriteToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando com o new LoggerConfiguration()");
            using (var log = new LoggerConfiguration()
                .MinimumLevel.Warning() //De warning p/ cima
                .WriteTo.Console()
                .CreateLogger())
            {
                log.Information("Hello, Serilog!");
                log.Warning("Goodbye, Serilog.");
            }

            Console.WriteLine("Testando com o Static");
            TesteComOStatic();

            Console.ReadLine();
        }

        private static void TesteComOStatic()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug() //De Debug p/ cima
                                      //.MinimumLevel.Information() //De information p/ cima
                .WriteTo.Console()
                .CreateLogger();

            Log.Debug("Debug");
            Log.Information("Hello again, Serilog!");
            var user = new { Name = "Nick", Id = "nblumhardt" };
            Log.Information("Logged on user {@User}", user);

            Log.CloseAndFlush();
        }
    }
}
