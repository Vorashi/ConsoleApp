using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Task_03
    {
        static void Main(string[] args)
        {
            List<int> tasks = new List<int>() { -5, 1, 9, -2, 6, -3};
            Console.WriteLine("Список: ");
            foreach (var item in tasks) {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("результат 1: ");
            var plusNumber = tasks.Where(x => x >= 1 == true).ToList();
            foreach (var item in plusNumber) {
                Console.Write($"{item} ");
            }
            
            Console.WriteLine();
            Console.WriteLine("результат 2: ");
            var minusNumber = tasks.Where(x => x <= -1 == true).ToList();
            foreach (var item in minusNumber)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
