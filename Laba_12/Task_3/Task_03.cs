using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Task_03
    {
        static void Main(string[] args)
        {
            int[,] userArray = new int[4, 3];
            int positiveNumber = 0;
            Console.WriteLine("Пожалуйста, введите значения матрицы 4 х 3: ");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 3; j++) {
                    userArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < userArray.GetLength(0); i++) {
                for (int j = 0; j < userArray.GetLength(1); j++) {
                    Console.Write($"{userArray[i, j]} ");
                    if (userArray[i, j] >= 0) { 
                        positiveNumber++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"кол-во положительных => {positiveNumber}");
            Console.ReadKey();
        }
    }
}
