using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Task_09
    {
        static void Main(string[] args)
        {
            
            int[,] matrix1 = GenerateRandomMatrix(3, 3, -10, 10);
            int[,] matrix2 = GenerateRandomMatrix(3, 3, -10, 10);

            
            Console.WriteLine("Матрица 1:");
            PrintMatrix(matrix1);
            Console.WriteLine("Матрица 2:");
            PrintMatrix(matrix2);

            
            int[,] resultMatrix = SumMat(matrix1, matrix2);
            Console.WriteLine("Результат матрицы:");
            PrintMatrix(resultMatrix);

            Console.ReadLine();
        }

       
        static int[,] GenerateRandomMatrix(int rows, int cols, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }
            return matrix;
        }

        
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        
        static int[,] SumMat(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
    }
}
