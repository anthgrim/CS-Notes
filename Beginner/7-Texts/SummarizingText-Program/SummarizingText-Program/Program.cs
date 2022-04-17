using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really really really really text";
            
            Console.WriteLine(StringUtility.SummarizeText(sentence,25));
        }
    }
}
