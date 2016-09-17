using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //if (inputNums.Length < 2)
            //{
            //    Console.WriteLine(0);
            //}
            //else
            //{
            //    int rows = inputNums[0];
            //    int columns = inputNums[1];

            //    var matrix = new char[rows][];
            //    for (int row = 0; row < rows; row++)
            //    {
            //        matrix[row] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            //    }
            //    int counter = 0;
            //    for (int row = 0; row < rows - 1; row++)
            //    {
            //        for (int col = 0; col < columns - 1; col++)
            //            if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col] && matrix[row][col] == matrix[row + 1][col + 1])
            //                counter++;
            //    }
            //    Console.WriteLine(counter);
            //}

            //Another Solution
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            char[][] matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            }

            int counter = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] && matrix[i][j] == matrix[i + 1][j] && matrix[i][j] == matrix[i + 1][j + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
            
        }
    }
}
