using System;
using System.Text.RegularExpressions;

namespace ExtractSentences
{
    public class ExtractSentences
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string[] entryText = Console.ReadLine().Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string pattern = $@"\b{word}\b";
            foreach (var sentence in entryText)
            {
                Match match = Regex.Match(sentence, pattern);
                if (match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}