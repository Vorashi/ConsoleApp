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
           Console.WriteLine("Введите значения для трех сторон треугольника: ");
           int numberOne = int.Parse(Console.ReadLine());
           int numberTwo = int.Parse(Console.ReadLine());
           int numberThree = int.Parse(Console.ReadLine());
           Perimeter(numberOne, numberTwo, numberThree);
            Console.ReadKey();
        }

        static void Perimeter(int numberOne, int numberTwo, int numberThree) {
            int result = numberOne + numberTwo + numberThree;
            Console.WriteLine($"Периметр: {result}");
        }
    }
}
