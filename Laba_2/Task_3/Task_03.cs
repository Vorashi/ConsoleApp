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
            Console.WriteLine("Введите трехзначное число: ");
            int numbers = int.Parse(Console.ReadLine());
            int hundreds = Math.Abs(numbers / 100);
            int tens = (numbers / 10) % 10;
            int units = numbers % 10;
            int result = hundreds * 100 + tens * 0 + units;
        //========================================================================//
            Console.WriteLine($"Цифры числа: {hundreds}, {tens}, {units};");
            Console.WriteLine($"Результат: {result}.");
            Console.ReadKey();
        }
    }
}
