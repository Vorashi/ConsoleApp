using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Task_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, y1, x2, y2): ");
            double argsXOne = double.Parse(Console.ReadLine());
            double argsXTwo = double.Parse(Console.ReadLine());
            double argsYOne = double.Parse(Console.ReadLine());
            double argsYTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Расстояние = " + Distance(argsXOne, argsXTwo, argsYOne, argsYTwo));
            Console.ReadKey();
        }

        static double Distance(double argsXOne, double argsXTwo, double argsYOne, double argsYTwo) {
            double result = Math.Sqrt(Math.Pow((argsXTwo - argsXOne), 2) + Math.Pow((argsYTwo - argsYOne), 2));
            return result;
        }
    }
}
