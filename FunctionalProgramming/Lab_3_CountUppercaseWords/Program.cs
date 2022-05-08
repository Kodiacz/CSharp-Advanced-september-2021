using System;
using System.Linq;

namespace Lab_3_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] upperCaseWords = words.Where(word => char.IsUpper(word[0])).ToArray();
            
            foreach (string word in upperCaseWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
