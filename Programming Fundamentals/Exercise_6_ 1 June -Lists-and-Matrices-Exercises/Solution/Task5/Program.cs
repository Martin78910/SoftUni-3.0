using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(long.Parse).ToArray();

            long[,] inputNumbs = new long[size[0], size[1]];
            inputNumbs = (ReadingInputNumbers(size));

            long[,] max3x3Platform = new long[3, 3];
            FindingMaxPlatform(inputNumbs);
        }

        static void FindingMaxPlatform(long[,] scannedMatrix)
        {
            long[,] maxPlatform = new long[3, 3];
            long bestSum = long.MinValue;
            long bestRow = 0;
            long bestCol = 0;

            for (long rowScan = 0; rowScan < scannedMatrix.GetLength(0) - 2; rowScan++)
            {
                for (long colScan = 0; colScan < scannedMatrix.GetLength(1) - 2; colScan++)
                {
                    long currentSum = scannedMatrix[rowScan, colScan] + scannedMatrix[rowScan, colScan + 1] + scannedMatrix[rowScan, colScan + 2] +
                                        scannedMatrix[rowScan + 1, colScan] + scannedMatrix[rowScan + 1, colScan + 1] + scannedMatrix[rowScan + 1, colScan + 2] +
                                        scannedMatrix[rowScan + 2, colScan] + scannedMatrix[rowScan + 2, colScan + 1] + scannedMatrix[rowScan + 2, colScan + 2];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = rowScan;
                        bestCol = colScan;
                    }
                }
            }

            Console.WriteLine(bestSum);
            for (long rowSave = bestRow; rowSave < bestRow + 3; rowSave++)
            {
                for (long colSave = bestCol; colSave < bestCol + 3; colSave++)
                {
                    Console.Write(scannedMatrix[rowSave, colSave] + " ");
                }
                Console.WriteLine();
            }
        }

        static long[,] ReadingInputNumbers(long[] matrixSize)
        {
            long[,] readNumbers = new long[matrixSize[0], matrixSize[1]];

            for (long rowRead = 0; rowRead < readNumbers.GetLength(0); rowRead++)
            {
                string[] rowNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (long colRead = 0; colRead < readNumbers.GetLength(1); colRead++)
                {
                    readNumbers[rowRead, colRead] = long.Parse(rowNumbers[colRead]);
                }
            }
            return readNumbers;


            //Another Solution

            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            long maxSum = long.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    long currentSum = (long)matrix[i][j] + (long)matrix[i][j + 1] + (long)matrix[i][j + 2] + (long)matrix[i + 1][j] + (long)matrix[i + 1][j + 1] + (long)matrix[i + 1][j + 2] + (long)matrix[i + 2][j] + (long)matrix[i + 2][j + 1] + (long)matrix[i + 2][j + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine(maxSum);

            for (int i = maxRow; i <= maxRow + 2; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i].Skip(maxCol).Take(3)));
            }

        }
    }
}
