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
            double[] doubleArray = { 1.1, -2.3, 3.7, 4.1, 5.6, 6.1, 7.1 };
            double max = double.MinValue;
            double min = double.MaxValue;
            PrintArray(doubleArray);
            FunctionMaxMin(doubleArray,ref max, ref min);
            Console.ReadKey();
        }

        static void PrintArray(double[] doubleArray) {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < doubleArray.Length; i++) {
                Console.Write($" {doubleArray[i]} ");
            }
            Console.WriteLine();
        }    

        static void FunctionMaxMin(double[] doubleArray, ref double max, ref double min) {
            foreach (var item in doubleArray) {
                if (item > max) {
                    max = item;
                } else if (item < min) {
                    min = item;
                }
            }
            Console.WriteLine($"максимальный элемент: {max} , минимальный элемент: {min}");
        }
    }
}
