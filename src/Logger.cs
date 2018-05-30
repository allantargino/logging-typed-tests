using System;

namespace actions
{
    public class Logger
    {
        private readonly Parser parser;

        public Logger(Parser parser)
        {
            this.parser = parser;
        }

        private string Parse(string pattern, params object[] args)
        {
            // Results keep almost the same if GetNumberedPattern method
            // is not called every time, since regex is compiled.
            var format = parser.GetNumberedPattern(pattern); 
            return string.Format(format, args);
        }

        public void Log(string pattern, params object[] args)
        {
            Console.WriteLine(Parse(pattern, args));
        }
    }
}
