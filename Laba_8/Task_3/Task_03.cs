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
            Console.WriteLine("Результат: ");
            IEnumerable<int> seq; 
            seq = Enumerable.Range(0, 9).Select((a) => 1 + a * 2);
            foreach (var x in seq)
                Console.Write($" {x} ");
            Console.ReadKey();
        }
    }
}
