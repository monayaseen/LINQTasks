using System.Collections.Generic;
using System.Linq;

namespace LINQTasks
{
    public class GettingLastWord
    {
        public static string GetTheLastWord(IEnumerable<string> words)
        {
            return words.Where(word => word.Contains("e")).OrderBy(word => word)
                .Select(word => $"The last word is  { word}").LastOrDefault();

        }
    }
}