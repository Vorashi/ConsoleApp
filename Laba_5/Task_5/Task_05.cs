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
            int resultNumber = 0;
            for (int i = 1; i <= 20; i+= 2)
            {
                resultNumber += i;
            }
            Console.WriteLine($"1 + 3 + 5 + 7 + 9 + 11 + 13 + 15 + 17 + 19 = {resultNumber}");
            Console.WriteLine($"Сумма всех наших чисел |=> {resultNumber}");
            Console.ReadKey();
        }
    }
}
