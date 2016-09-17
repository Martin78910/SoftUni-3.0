using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            bool isPalindrome = true;
            for (int i = 0; i < sb.Length / 2; i++)
            {
                if (sb[i] != sb[sb.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine(-1);
                return;
            }

            for (int i = 0; i < sb.Length; i++)
            {
                char ch = sb[i];
                sb = sb.Remove(i, 1);

                isPalindrome = true;
                for (int j = 0; j < sb.Length / 2; j++)
                {
                    if (sb[j] != sb[sb.Length - j - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine(i);
                    return;
                }

                sb.Insert(i, ch);
            }





            //Another Solution 
            //string i = Console.ReadLine();

            //int k = i.Distinct().Count();

            //if (k != 1)
            //{
            //    int x = 0;
            //    int o = i.Select(c => i.Remove(x++, 1)).Any(s => s.Reverse().SequenceEqual(s)) ? x : 0;
            //    Console.WriteLine(x - 1);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}
        }
    }
}
