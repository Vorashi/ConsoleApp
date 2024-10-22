using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Task_07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numberFirst = int.Parse(Console.ReadLine());
            double result = 0;
            if (numberFirst > 0) {
                result = Math.Sin(numberFirst) * 2;
            } else if (numberFirst <= 0) {
                result = 6 - numberFirst;
            } else {
                Console.WriteLine("ТЫ КТО ТАКОЙ, ЧТОБЫ ТАКОЕ СДЕЛАТЬ!?");
            }
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}
