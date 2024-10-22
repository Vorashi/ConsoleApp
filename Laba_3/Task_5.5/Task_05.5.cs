using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 123;
            Console.WriteLine($"Дано трехзначное число |=> {firstNumber}");

            int hungreds = firstNumber / 100;
            int tens = (firstNumber / 10) % 10;
            int ones = firstNumber % 10;

            int resultOne = ones * 100 + tens * 10 + hungreds;
            int resultFive = ones * 100 + hungreds * 10 + tens;
            int resultTwo = tens * 100 + ones * 10 + hungreds;
            int resultFour = tens * 100 + hungreds * 10 + ones;
            int resultThree = hungreds * 100 + ones * 10 + tens;
            int resultZero = hungreds * 100 + tens * 10 + ones;

            Console.WriteLine($"Первая вариация |=> {resultOne}");
            Console.WriteLine($"Вторая вариация |=> {resultFive}");
            Console.WriteLine($"Третья вариация |=> {resultTwo}");
            Console.WriteLine($"Четвертая вариация |=> {resultFour}");
            Console.WriteLine($"Пятая вариация |=> {resultThree}");
            Console.WriteLine($"Шестая вариация |=> {resultZero}");

            Console.ReadKey();
        }
    }
}
