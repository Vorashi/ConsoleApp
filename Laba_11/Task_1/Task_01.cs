using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Task_01
    {
        static void Main(string[] args)
        {
            int[] masInt = { 1, 6, 2, 7, 5 };
            double[] masDouble = { 1.2, 6.4, 2.1, 7.5, 8.1 };
            MyFunction.Print(masInt);
            MyFunction.PrintEven(masInt);
            MyFunction.Print(masDouble);
            MyFunction.PrintEven(masDouble);
            Console.ReadKey();
        }
    }
    public static class MyFunction
    {
        public static void Print<T>(this T[] mas)
        {
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();
        }

        public static void PrintEven<T>(this T[] mas)
        {
            Console.Write("Элементы с четными индексами: ");
            for (int i = 0; i < mas.Length; i += 2)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine("");
        }
    }
}