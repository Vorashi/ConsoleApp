using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Task_05
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.AddRange(Enumerable.Range(-5, 11));

            foreach (var item in numberList) {
                Console.Write($"{item} ");
            }


            Console.WriteLine("результат 1: ");
            var Nstring = numberList.Where(x => x * 3);
            foreach (var item in Nstring)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("результат 2: ");
            Console.ReadKey();
        }
    }
}
