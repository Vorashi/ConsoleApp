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
            // Классический while
            int counterFirst = 3;
            while (counterFirst <= 21) {
                counterFirst += 2;
                Console.Write($" {counterFirst} ");
            }
            
            Console.WriteLine();

            // Вариант с do while
            int counterLast = 3;
            do {
                counterLast += 2;
                Console.Write($" {counterLast} ");
            } while (counterLast <= 21);
            Console.ReadKey();
        }
    }
}
