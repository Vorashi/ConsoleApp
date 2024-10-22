using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Task_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во строк: ");
            int firstUserNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("введите кол-во столбцов: ");
            int lastUserNumber = int.Parse(Console.ReadLine());
            int min = int.MinValue;
            int max = int.MaxValue;
            int[,] userArray = new int[firstUserNumber, lastUserNumber];
            Console.WriteLine("Массив: ");
            FillMatrix(userArray, firstUserNumber, lastUserNumber);
            FindMinMaxArr(userArray, ref min, ref max);
            Console.ReadKey();
        }

        private static int[,] FillMatrix(int[,] userArray, int firstUserNumber,int lastUserNumber) {
            Random rand = new Random();
            for (int i = 0; i < firstUserNumber; i++) {
                for (int j = 0; j < lastUserNumber; j++) {
                    Console.Write($"{userArray[i, j] = rand.Next(-15,15)} ");
                }
                Console.WriteLine();    
            }
            return userArray;
        }

        private static void FindMinMaxArr(int[,] userArray, ref int min, ref int max) {
            for (int i = 0; i < userArray.GetLength(0); i++) {
                for (int j = 0; j < userArray.GetLength(1); j++) {
                    if (userArray[i, j] > min) {
                        min = userArray[i, j];
                    } else if (userArray[i, j] < max) { 
                        max = userArray[i, j];
                    }
                }
            }
            Console.Write($"min => {max}, max => {min} ");
        }
    }
}
