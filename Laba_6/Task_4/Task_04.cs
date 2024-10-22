using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Task_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 вещественных чисел: ");
            int counter = 0;
            double result = 1.0;
            while (counter < 5) { 
            double userNumber = double.Parse(Console.ReadLine());
                result += userNumber;
                counter++;
            }
            Console.WriteLine($"Сумма введенных чисел = {result}");
            Console.ReadKey();
        }
    }
}
