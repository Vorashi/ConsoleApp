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
            Console.WriteLine("Введите число: ");
            int numberFirst = int.Parse(Console.ReadLine());
            string trueResult = "введенное число положительное";
            string falseResult = "введенное число отрицательное";
            string resultFirst;
            if (numberFirst >= 0) {
               resultFirst = trueResult;
            } else { 
                resultFirst = falseResult; 
            }
            Console.WriteLine($"Результат: {resultFirst}");
        //========================================================================================//
            Console.WriteLine("Введите число: ");
            int numberLast = int.Parse(Console.ReadLine());
            string resultLast;
            if (numberLast >= 0)
            {
                resultLast = trueResult;
            }
            else
            {
                resultLast = falseResult;
            }
            Console.WriteLine($"Результат: {resultLast}");
            Console.ReadKey();
        }
    }
}
