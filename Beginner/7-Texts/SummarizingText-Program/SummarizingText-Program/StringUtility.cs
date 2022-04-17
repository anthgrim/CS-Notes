using System;
using System.Collections.Generic;

namespace SummarizingText_Program
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalChars = 0;
                var sumWords = new List<string>();

                foreach (var word in words)
                {
                    sumWords.Add(word);

                    totalChars += word.Length + 1;

                    if (totalChars > maxLength)
                    {
                        break;
                    }
                }

                return String.Join(" ", sumWords) + "...";
            }
        }
    }
}
