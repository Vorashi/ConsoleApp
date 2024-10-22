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
            Console.WriteLine("Введите два числа: ");

            int numberFirst = int.Parse(Console.ReadLine());
            int numberLast = int.Parse(Console.ReadLine());
            double sum = (numberFirst + numberLast) / 2.0;

            Console.WriteLine($"Среднее арифметическое: {sum}");
            Console.ReadKey();
        }
    }
}
