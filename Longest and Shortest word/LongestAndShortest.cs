using System;
using System.Linq;

namespace Longest_and_Shortest
{
    public static class Program
    {
        private static string GetShortestWord(string text)
        {
            text = string.Concat(text.Where(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x))).ToLower();

            string[] words = text.Split(' ');

            string shortestWord = words[0];
            int shortestLength = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length < shortestLength)
                {
                    shortestWord = word;
                    shortestLength = word.Length;
                }
            }

            return shortestWord;


        }

        private static string GetLongestWord(string text)
        {
            text = string.Concat(text.Where(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x))).ToLower();

            string[] words = text.Split(' ');

            string longestWord = words[0];
            int longestLength = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > longestLength)
                {
                    longestWord = word;
                    longestLength = word.Length;
                }
            }

            return longestWord;
        }

        public static void Main()
        {
            Console.WriteLine("Enter a sentence");
            string text = Console.ReadLine();

            string shortestWord = GetShortestWord(text);
            string longestWord = GetLongestWord(text);

            Console.WriteLine($"The shortest word is: {shortestWord}");
            Console.WriteLine($"The longest word is: {longestWord}");
        }
    }
}