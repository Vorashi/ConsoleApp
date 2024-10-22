using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    internal class Task_07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы: ");
            int firstUserNumber = int.Parse(Console.ReadLine());
            int[,] userArray = new int [firstUserNumber, firstUserNumber];
            Console.WriteLine("Массив: ");
            FillMatrix(userArray, firstUserNumber);

            Console.WriteLine("Произведение элементов главной диагонали =  ");
            Console.ReadKey();
        }

        private static void FillMatrix(int[,] userArray, int firstUserNumber)
        {
            Random rand = new Random();
            for (int i = 0; i < firstUserNumber; i++)
            {
                for (int j = 0; j < firstUserNumber; j++)
                {
                    Console.Write($"{userArray[i, j] = rand.Next(0,9)} ");
                }
                Console.WriteLine();
            }
        }
    }
}
