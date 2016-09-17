using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Task24
    {
        static void Main(string[] args)
        {
            {
                checked
                {
                    int startNum;
                  
                    while (!int.TryParse(Console.ReadLine(), out startNum) || startNum < 0);

                    int endNum;
                 
                    while (!int.TryParse(Console.ReadLine(), out endNum) || endNum <= startNum);

                    List<int> primes = FindPrimesInGivenRangeAndPutThemInTheList(startNum, endNum);
                    PrintListOfIntegers(primes);
                }
            }
        }
        private static void PrintListOfIntegers(List<int> numsList)
        {
            checked
            {
                if (numsList.Count > 0)
                {
                
                    for (int i = 0; i < numsList.Count; i++)
                    {
                        Console.Write(numsList[i]);
                        if (i < numsList.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("In Given Range No Any Prime Number!");
                    Console.WriteLine("(empty list)");
                }
            }
        }

        private static List<int> FindPrimesInGivenRangeAndPutThemInTheList(int start, int end)
        {
            checked
            {
                List<int> primes = new List<int>();
                for (int num = start; num <= end; num++)
                {
                    bool isPrimeNum = CheckTheIntegerNumberIsPrimeOrNot(num);
                    if (isPrimeNum)
                    {
                        primes.Add(num);
                    }
                }

                return primes;
            }
        }

        private static bool CheckTheIntegerNumberIsPrimeOrNot(int num)
        {
            checked
            {
                if (num < 2)
                {
                    return false;
                }
                else
                {
                    bool isPrime = true;
                    int maxDivider = (int)Math.Sqrt(num);
                    for (int i = 2; i <= maxDivider; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    return isPrime;
                }
            }
        }
    }
}