using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Task_01
    {
        static void Main(string[] args)
        {
            int[,] t = { {-8,-14,-19,-18},
                         { 25,28, 26, 20},
                         { 11,18, 20, 25} };
            Console.WriteLine($"1-е задание: {t[1, 3]} and {t[2, 0]} "); // Начало решения первой задачи

            Console.Write("2-е задание: "); // Начало решения второй задачи
            for (int i = 0; i < t.GetLength(1); i++) {
                Console.Write($"{t[1, i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("3-е задание: "); // Начало решения третьей задачи
            for (int i = 0; i < t.GetLength(0); i++) {
                for (int j = 0; j < t.GetLength(1); j++) {
                    Console.Write($"{t[i, j]} ");
                }
                Console.WriteLine("");
            }

            int sum = 0;
            for (int i = 0; i < t.GetLength(1); i++) {
                sum += t[2, i];
            }
            sum /= 4;
            Console.WriteLine($"4-е задание: {sum}"); // Начало решения четвертой задачи

            Console.WriteLine("5-е задание:"); // Начало решения пятой задачи
            for (int i = 0; i < t.GetLength(0); i++) {
                for (int j = 0; j < t.GetLength(1); j++) {
                    if (t[i, j] >= 24 && t[i, j] <= 26) {
                        Console.WriteLine($"станция {i + 1} день {j} ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}