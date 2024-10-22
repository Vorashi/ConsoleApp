using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Task_02
    {
        static void Main(string[] args)
        {
           int[,] userArray = new int[2, 3];
           int sum = 0;
            Console.WriteLine("Введите 6 значений для матрицы 2 х 3: ");
                for (int i = 0; i < 2; i++) {
                    for (int j = 0; j < 3; j++) {
                        userArray[i, j] = int.Parse(Console.ReadLine());
                    }
                }

            Console.WriteLine("Массив: ");
                for (int i = 0; i < userArray.GetLength(0); i++) {
                    for (int j = 0; j < userArray.GetLength(1); j++) {
                        Console.Write($"{userArray[i, j]} ");
                        sum += userArray[i, j];
                    }
                    Console.WriteLine();
                }
            Console.WriteLine($"Сумма: {sum}");
            Console.ReadKey();
        }
    }
}
