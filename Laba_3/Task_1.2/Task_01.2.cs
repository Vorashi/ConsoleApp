using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            Console.WriteLine("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());

            double result = PI * Math.Sqrt(radius);
            Console.WriteLine($"Площадь круга равна |=> {result}");
            Console.ReadKey();
        }
    }
}
