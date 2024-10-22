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
            Console.WriteLine("Последовательность от 1 до 100: ");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($" {i} ");
            }

            for (int reversI = 99; reversI >= 1; reversI--)
            {
                Console.Write($" {reversI} ");
            }

            Console.ReadKey();
        }
    }
}
