using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Task_06
    {
        static void Main(string[] args)
        {
            double resultNumber = 1.0;
            Console.WriteLine("Введите 10 чисел: ");
            for (int i = 0; i <= 10; i++)
            {
                double userNumbers = double.Parse(Console.ReadLine());
                resultNumber *= userNumbers;
            }
            Console.WriteLine($"Сумма всех наших чисел |=> {resultNumber}");
            Console.ReadKey();
        }
    }
}
