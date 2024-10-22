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
            Console.WriteLine("Введите 4 числа:");
            int numberFirst = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());
            bool resultFirst = (numberFirst + numberTwo) > (numberThree + numberFour) ? true : false;
            Console.WriteLine($"Результат: {resultFirst}");

            Console.WriteLine("Введите 4 числа:");
            int numberFive = int.Parse(Console.ReadLine());
            int numberSix = int.Parse(Console.ReadLine());
            int numberEight = int.Parse(Console.ReadLine());
            int numberNine = int.Parse(Console.ReadLine());
            bool resultLast = (numberFive + numberSix) > (numberEight + numberNine) ? true : false;
            Console.WriteLine($"Результат: {resultLast}");
            Console.ReadKey();
        }
    }
}
