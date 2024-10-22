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
            Console.WriteLine("Введите значения для трех сторон треугольника: ");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Периметр = " + Perimeter(numberOne, numberTwo, numberThree));
            Console.ReadKey();
        }

        static int Perimeter(int numberOne, int numberTwo, int numberThree)
        {
            int result = numberOne + numberTwo + numberThree;
            return result;
        }
    }
}
