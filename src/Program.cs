using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace actions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init
            var n = 10000;
            var parser = new Parser();
            var logger = new Logger(parser);
            var typedLogger = new TypedLogger(parser);

            // Method 1 (formating, boxing and unboxing)
            var watch1 = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
                logger.Log("My name is {name} and I am {age}.", "Allan", 24);
            watch1.Stop();
            var elapsedMsMethod1 = watch1.ElapsedMilliseconds;

            //Method 2 (typed delegate)
            var watch2 = Stopwatch.StartNew();
            var logAction = typedLogger.Define<string, int>("My name is {name} and I am {age}.");
            for (int i = 0; i < n; i++)
                logAction("Allan", 24);
            watch2.Stop();
            var elapsedMsMethod2 = watch2.ElapsedMilliseconds;

            //Results
            Console.WriteLine("=================================================");
            Console.WriteLine("RESULTS:");
            Console.WriteLine($"{nameof(elapsedMsMethod1)}: {elapsedMsMethod1}");
            Console.WriteLine($"{nameof(elapsedMsMethod2)}: {elapsedMsMethod2}");
            Console.WriteLine("=================================================");
            Console.ReadKey();
        }
    }
}
