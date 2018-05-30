using System;

namespace actions
{
    public class TypedLogger
    {
        private readonly Parser parser;

        public TypedLogger(Parser parser)
        {
            this.parser = parser;
        }

        public Action<T1, T2> Define<T1, T2>(string pattern)
        {
            var format = parser.GetNumberedPattern(pattern);

            return (v1, v2) =>
            {
                Console.WriteLine(format.Replace("{0}", v1.ToString()).Replace("{1}", v2.ToString()));
            };
        }
    }
}
