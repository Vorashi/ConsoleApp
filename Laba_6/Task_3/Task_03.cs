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
            int result = 1;
            int counter = 10;
            while (counter < 20) {
                counter += 2;
                Console.Write($" {counter} *");
                result *= counter;
            }
            Console.Write($" = {result}");
            Console.ReadKey();
        }
    }
}
