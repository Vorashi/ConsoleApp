using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Task_06
    {
        static void Main(string[] args)
        {
            int[,] randomArray = new int[3,4];
            Console.WriteLine("Матрица: ");
            FillMatrix(randomArray);
            Console.WriteLine("Введите номер столбца (первый столбец - 0-й): ");
            int M = int.Parse(Console.ReadLine());
            int product;
            FindProductOfColumn(randomArray, M, out product);
            Console.WriteLine($"Произведение элементов 2-го столбца = {product}");
            Console.ReadKey();
        }

        private static void FillMatrix(int[,] randomArray) {
            Random rand = new Random();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write($"{randomArray[i, j] = rand.Next(1, 9)} ");
                }
                Console.WriteLine();
            }
        }

        static void FindProductOfColumn(int[,] randomArray, int M, out int product) {
            product = 1;
            for (int i = 0; i < randomArray.GetLength(0); i++) {
                product *= randomArray[i, M];
            }
        }
    }
}
