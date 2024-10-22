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
            Console.WriteLine("Введите сторону треугольника: ");
            int numderFirst = int.Parse(Console.ReadLine());
            double square = Math.Pow(numderFirst, 2) * Math.Sqrt(3) / 4;
            int perimeter = numderFirst * 3;

            
            Console.WriteLine($"Периметр треугольника: {perimeter}");
            Console.WriteLine($"Площадь: {square}");    
            Console.ReadKey();
        }
    }
}
