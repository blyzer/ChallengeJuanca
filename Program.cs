using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringWrap;
            int integerLength;

            Console.WriteLine("Enter the string to wrap");
            stringWrap = Console.ReadLine();
            
            Console.WriteLine("Enter the integer to unwrap the string");
            Int32.TryParse(Console.ReadLine(), out integerLength);

            List<string> wrappedLines =  WrapText(stringWrap, integerLength);
            foreach (var item in wrappedLines)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static List<string> WrapText(string unWrappedText, int lengthOfLines)
        {
            List<string> wrappedLines = new List<string>();
            wrappedLines = Regex.Matches(unWrappedText, ".{1," + lengthOfLines + "}\\b").Cast<Match>().Select(m => m.Value).ToList();
            wrappedLines.ToString().Replace(" ", "");
            return wrappedLines;
        }
    }
}
