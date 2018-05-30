using System.Text.RegularExpressions;

namespace actions
{
    public class Parser
    {
        private readonly Regex _regex;

        public Parser()
        {
            _regex = new Regex(@"\{[a-z]*\}", RegexOptions.Compiled);
        }

        public string GetNumberedPattern(string pattern)
        {
            int i = 0;
            return _regex.Replace(pattern, (match) => {
                return $"{{{i++}}}";
            });
        }
    }
}
