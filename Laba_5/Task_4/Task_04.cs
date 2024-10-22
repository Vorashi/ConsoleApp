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
            int resultNumber = 0;
            Console.WriteLine("Введите 10 чисел: ");
            for (int i = 0; i <= 10; i++)
            {
                int userNumbers = int.Parse(Console.ReadLine());
                resultNumber += userNumbers;
            }
            Console.WriteLine($"Сумма всех наших чисел |=> {resultNumber}");
            Console.ReadKey();
        }
    }
}
