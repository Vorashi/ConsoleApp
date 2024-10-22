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
            Console.WriteLine("Введите три целых числа: ");
            int numberFirst = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            bool resultFirst = (numberFirst != numberTwo || numberTwo != numberThree && numberFirst != numberThree) ? true : false;
            Console.WriteLine($"Результат: {resultFirst}.");
    //=================================================================================================================================//
            Console.WriteLine("Введите три целых числа: ");
            int numberFour = int.Parse(Console.ReadLine());
            int numberFive = int.Parse(Console.ReadLine());
            int numberSix = int.Parse(Console.ReadLine());
            bool resultTwo = (numberFour != numberFive || numberFive != numberSix && numberFour != numberSix) ? true : false;
            Console.WriteLine($"Результат: {resultTwo}.");
    //=================================================================================================================================//
            Console.WriteLine("Введите три целых числа: ");
            int numberSeven = int.Parse(Console.ReadLine());
            int numberEight = int.Parse(Console.ReadLine());
            int numberNine = int.Parse(Console.ReadLine());
            bool resultLast = (numberSeven != numberEight || numberEight != numberNine && numberSeven != numberNine) ? true : false;
            Console.WriteLine($"Результат: {resultLast}.");
            Console.ReadKey();
        }
    }
}
