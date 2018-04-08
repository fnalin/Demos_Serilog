using Serilog;
using Serilog.Formatting.Compact;
using System;

namespace DemoSeriLog.WriteToJSONFile
{
    //github.com/datalust/clef-tool -> clef
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(new CompactJsonFormatter(), "log.clef")
                .CreateLogger();

            var itemCount = 99;
            for (var itemNumber = 0; itemNumber < itemCount; ++itemNumber)
                Log.Debug("Processing item {ItemNumber} of {ItemCount}", itemNumber, itemCount);

            Log.CloseAndFlush();

            Console.WriteLine("FIM");
            Console.ReadLine();
        }
    }
}
