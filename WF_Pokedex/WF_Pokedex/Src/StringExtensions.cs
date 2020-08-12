using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Pokedex
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

        private static string CapitalizeWords(string baseStr, char splitChar)
        {
            List<string> words = baseStr.Split(splitChar).ToList();
            words.ForEach(w => CapitalizeWord(w));
            return words.Aggregate((s1, s2) => s1 + splitChar + s2);

        }

        private static string CapitalizeWord(string word)
        {
            return word.First().ToString().ToUpper() + word.Substring(1);
        }
    }
}
