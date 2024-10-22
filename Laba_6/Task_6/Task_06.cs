using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace Task_6
{
    internal class Task_06
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 3) {
                Console.WriteLine("Введите x: ");
                double x = double.Parse(ReadLine());
                double y = 0;
                double powe = x - 3;
                y = 4 * Math.Pow(powe, 6) - 7 * Math.Pow(powe, 3) + 2;
                Console.WriteLine($"x = {x}; y = {y}");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
