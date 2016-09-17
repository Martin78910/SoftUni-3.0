using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string[] input = Console.ReadLine().Split();
            //    int r = int.Parse(input[1]);
            //    int c = int.Parse(input[2]);

            //    switch (input[0])
            //    {
            //        case "A": PrintMatrix(TypeA(r, c)); break;
            //        case "B": PrintMatrix(TypeB(r, c)); break;
            //        case "C": PrintMatrix(TypeC(r, c)); break;
            //        case "D": PrintMatrix(TypeD(r, c)); break;
            //        default: break;
            //    }
            //}

            //static int[,] TypeA(int r, int c)
            //{
            //    int[,] m = new int[r, c];
            //    int number = 1;

            //    for (int i = 0; i < c; i++)
            //    {
            //        for (int j = 0; j < r; j++)
            //        {
            //            m[j, i] = number;
            //            number++;
            //        }
            //    }

            //    return m;
            //}

            //static int[,] TypeB(int r, int c)
            //{
            //    int[,] m = new int[r, c];
            //    int number = 1;

            //    for (int i = 0; i < c; i++)
            //    {
            //        for (int j = 0; j < r; j++)
            //        {
            //            if (i % 2 == 0) { m[j, i] = number; number++; }
            //            else { m[r - 1 - j, i] = number; number++; }
            //        }
            //    }

            //    return m;
            //}

            //static int[,] TypeC(int r, int c)
            //{
            //    int[,] m = new int[r, c];
            //    int number = 1;

            //    for (int i = r - 1; i >= 0; i--)
            //    {
            //        int startR = i;
            //        for (int j = 0; j < r - startR; j++)
            //        {
            //            if (j > c - 1) { break; }
            //            m[startR + j, j] = number; number++;
            //        }
            //    }

            //    for (int i = 1; i < c; i++)
            //    {
            //        int startC = i;
            //        for (int j = 0; j < c - startC; j++)
            //        {
            //            if (j > r - 1) { break; }
            //            m[j, startC + j] = number; number++;
            //        }
            //    }

            //    return m;
            //}

            //static int[,] TypeD(int r, int c)
            //{
            //    int[,] m = new int[r, c];
            //    int number = 1;
            //    int indexR = 0;
            //    int indexC = 0;

            //    while (number <= r * c)
            //    {
            //        m[indexR, indexC] = number;
            //        number++; ;

            //        bool canGoDown = (indexR + 1) < r && m[indexR + 1, indexC] == 0 && !((indexC - 1) >= 0 && m[indexR, indexC - 1] == 0);
            //        if (canGoDown) { indexR++; continue; }
            //        bool canGoRight = (indexC + 1) < c && m[indexR, indexC + 1] == 0;
            //        if (canGoRight) { indexC++; continue; }
            //        bool canGoUp = (indexR - 1) >= 0 && m[indexR - 1, indexC] == 0;
            //        if (canGoUp) { indexR--; continue; }
            //        bool canGoLeft = (indexC - 1) >= 0 && m[indexR, indexC - 1] == 0;
            //        if (canGoLeft) { indexC--; continue; }
            //    }

            //    return m;
            //}

            //static void PrintMatrix(int[,] m)
            //{
            //    for (int i = 0; i < m.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < m.GetLength(1); j++)
            //        {
            //            Console.Write($"{m[i, j]} ");
            //        }
            //        Console.WriteLine();

            //}


            //Another Solution 

            string[] tokens = Console.ReadLine().Split(' ');
            char type = char.Parse(tokens[0]);
            int rows = int.Parse(tokens[1]);
            int cols = int.Parse(tokens[2]);
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
            }

            switch (type)
            {
                case 'A': A(matrix, rows, cols); break;
                case 'B': B(matrix, rows, cols); break;
                case 'C': C(matrix, rows, cols); break;
                case 'D': D(matrix, rows, cols); break;
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        static void A(int[][] matrix, int rows, int cols)
        {
            int counter = 1;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[j][i] = counter++;
                }
            }
        }

        static void B(int[][] matrix, int rows, int cols)
        {
            int counter = 1;

            for (int i = 0; i < cols; i++)
            {
                int k = i % 2 == 0 ? 0 : matrix.Length - 1;

                for (int j = k; j < matrix.Length && j >= 0; j = k == 0 ? j + 1 : j - 1)
                {
                    matrix[j][i] = counter++;
                }
            }
        }

        static void C(int[][] matrix, int rows, int cols)
        {
            int counter = 1;
            int difference = rows - 1;
            //for(int k=rows-1 + cols-1; k>=0; k--)
            while (difference > -cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i - j == difference)
                        {
                            matrix[i][j] = counter++;
                        }
                    }
                }
                difference--;
            }
        }

        static void D(int[][] matrix, int rows, int cols)
        {
            int startRow = 0;
            int startCol = 0;
            int endRow = rows - 1;
            int endCol = cols - 1;
            int k = 1;
            while (true)
            {
                bool endLoop = false;
                for (int i = startRow; i <= endRow; i++)
                {
                    matrix[i][startCol] = k++;
                    if (k > rows * cols)
                    {
                        return;
                    }
                }

                for (int i = startCol + 1; i <= endCol; i++)
                {
                    matrix[endRow][i] = k++;
                    if (k > rows * cols)
                    {
                        return;
                    }
                }

                for (int i = endRow - 1; i >= startRow; i--)
                {
                    matrix[i][endCol] = k++;
                    if (k > rows * cols)
                    {
                        return;
                    }
                }

                for (int i = endCol - 1; i > startCol; i--)
                {
                    matrix[startRow][i] = k++;
                    if (k > rows * cols)
                    {
                        return;
                    }
                }

                startCol++;
                startRow++;
                endRow--;
                endCol--;
            }
        }
    }
}
