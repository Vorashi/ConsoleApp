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
            Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, y1, x2, y2): ");
            int argsXOne = int.Parse(Console.ReadLine());
            int argsXTwo = int.Parse(Console.ReadLine());
            int argsYOne = int.Parse(Console.ReadLine());
            int argsYTwo = int.Parse(Console.ReadLine());

            Distance(argsXOne, argsXTwo, argsYOne, argsYTwo);
            Console.ReadKey();
        }

        static void Distance(int argsXOne, int argsXTwo, int argsYOne, int argsYTwo) {
            double result = Math.Sqrt(Math.Pow((argsXTwo - argsXOne), 2) + Math.Pow((argsYTwo - argsYOne), 2));
            Console.WriteLine($"Между точками x1 = {argsXOne}, y1 = {argsYOne}, x2 = {argsXTwo}, y2 = {argsYTwo}, расстояние: {result}");
        }
    }
}
