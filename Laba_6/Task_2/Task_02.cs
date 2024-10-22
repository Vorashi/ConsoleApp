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
            // Классический while
            int counterFirst = 15;
            while (counterFirst >= 0) {
                counterFirst -= 3;
                Console.Write($" {counterFirst} ");
            }

            Console.WriteLine();

            // Вариант с do while
            int counterLast = 15;
            do { 
                counterLast -= 3;
                Console.Write($" {counterLast} ");
            } while (counterLast >= 0);
            Console.ReadKey();
        }
    }
}
