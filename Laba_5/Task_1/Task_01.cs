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
            Console.WriteLine("Последовательность чисел от -3 до 24, с инкрементом в 3 на каждой итерации.");
            Console.Write("Последовательность: ");
            for (int i = -3; i <= 24; i += 3) {
                Console.Write($" {i} ");
            }
            Console.ReadKey();
        }
    }
}
