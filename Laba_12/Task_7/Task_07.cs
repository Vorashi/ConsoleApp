using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Task_07
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int userNumber = int.Parse(Console.ReadLine());
            int[,] userArray = new int[userNumber, userNumber];
            FillMatrix(userArray, userNumber);
            Console.WriteLine($"Произведение элементов главной диагонали = {Product(userArray)}");
            Console.ReadKey();
        }

        static void FillMatrix(int[,] randomArray, int userNumber)
        {
            Random rand = new Random();
            for (int i = 0; i < userNumber; i++)
            {
                for (int j = 0; j < userNumber; j++)
                {
                    Console.Write($"{randomArray[i, j] = rand.Next(0, 9)} ");
                }
                Console.WriteLine();
            }
        }

        static int Product(int[,] userArray)
        {
            int product = 1;
            for (int i = 0; i < userArray.GetLength(0); i++)
                product *= userArray[i, i];
            return product;
        }
    }
}
