using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxnumbers = 0;
            int count = 1;
            int maxcount = 1;
            int pos = 0;
            while (pos < numbers.Count - 1)
            {

                if (numbers[pos] == numbers[pos + 1])
                {
                    count++;

                    if (count > maxcount)
                    {
                        maxcount = count;
                        maxnumbers = numbers[pos];
                    }

                }
                else
                {
                    count = 1;
                }
                pos++;
                if (maxcount == 1)
                {
                    maxnumbers = numbers[0];
                }
            }
            for (int i = 0; i < maxcount; i++)
            {
                Console.Write(maxnumbers);
                Console.Write(" ");

                //Another Solution

                List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int currentSeqStartIndex = 0;
                int currentSeqLength = 1;
                int longestSeqStartIndex = 0;
                int longestSeqLength = 1;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] == list[i + 1])
                    {
                        currentSeqLength++;
                        if (currentSeqLength > longestSeqLength)
                        {
                            longestSeqLength = currentSeqLength;
                            longestSeqStartIndex = currentSeqStartIndex;
                        }
                    }
                    else
                    {
                        currentSeqStartIndex = i + 1;
                        currentSeqLength = 1;
                    }
                }

                List<int> result = list.Skip(longestSeqStartIndex).Take(longestSeqLength).ToList();

                Console.WriteLine(string.Join(" ", result));
            
            }
        }
    }

