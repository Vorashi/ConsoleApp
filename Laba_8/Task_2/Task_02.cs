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
            Console.WriteLine("Введите натуральные числа n: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральные числа a: ");
            int lastNumber = int.Parse(Console.ReadLine());
            IEnumerable<int> seq;
            seq = Enumerable.Range(firstNumber, lastNumber);
            Console.WriteLine("Результат: ");
            foreach (int num in seq) {
                Console.Write($" {num} ");
            }
            Console.ReadKey();
        }
    }
}
