using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Task_05
    {
        static void Main(string[] args)
        {
            int[,] randomArray = new int[5, 5];
            Console.WriteLine("Матрица: ");
            FillMatrix(randomArray);
            Console.WriteLine("Результирующая матрица: ");
            PlaceZero(randomArray);
            Console.ReadKey();
        }

        private static int[,] FillMatrix(int[,] randomArray)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write($"{randomArray[i, j] = rand.Next(0, 9)} ");
                }
                Console.WriteLine();
            }
            return randomArray;
        }


        static void PlaceZero(int[,] randomArray) {
            for (int i = 0; i < randomArray.GetLength(0); i++) {
                for (int j = 0; j < randomArray.GetLength(1); j++) {
                    if (i == 0 || j == 0 || i == randomArray.GetLength(0) - 1 || j == randomArray.GetLength(1) - 1) {
                        randomArray[i , j] = 0;
                    }
                    Console.Write($"{randomArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
