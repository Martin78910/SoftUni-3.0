using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            List<string> palindromes = new List<string>();

            foreach (string word in words)
            {
                bool isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - i - 1])
                    {
                        isPalindrome = false;
                    }
                }

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();
            Console.WriteLine(string.Join(", ", palindromes));

            

            //Another Solution

        //    char[] separators = { ' ', ',', '.', '?', '!' };
        //    string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        //    List<string> output = new List<string>();
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        string word = input[i];
        //        bool palindrome = IsPalindrome(word);
        //        if (palindrome)
        //        {
        //            if (!output.Contains(word))
        //            {
        //                output.Add(word);
        //            }
        //        }
        //    }
        //    output.Sort();
        //    Console.WriteLine(string.Join(", ", output));
        //}

        //private static bool IsPalindrome(string word)
        //{
        //    int min = 0;
        //    int max = word.Length - 1;
        //    while (true)
        //    {
        //        if (min > max)
        //        {
        //            return true;
        //        }
        //        char a = word[min];
        //        char b = word[max];
        //        if (a != b)
        //        {
        //            return false;
        //        }
        //        min++;
        //        max--;
        //    }
        }
    }
}
