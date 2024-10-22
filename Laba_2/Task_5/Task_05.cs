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
            Console.WriteLine("Введите три целых числа: ");
            int numberFirst = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberLast = int.Parse(Console.ReadLine());
            double perimeter = (numberFirst + numberTwo + numberLast) / 2;  
            double result = Math.Sqrt(perimeter * (perimeter - numberFirst) * (perimeter  - numberTwo) * (perimeter - numberLast));
            bool perimeterFull = 
            if () { 
                Console.WriteLine($"Результат: существует, его площадь - {result} "); 
            } else { 
                Console.WriteLine("Результат: такого треугольника не существует"); 
            }
            Console.ReadKey();
        }
    }
}
