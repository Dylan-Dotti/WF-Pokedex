using System.Linq;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string word)
        {
            if (word.Length > 0)
            {
                return word.First().ToString().ToUpper() + word.Substring(1);
            }
            return word;
        }
    }
}
