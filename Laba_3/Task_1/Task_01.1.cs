using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numberOne = 7;
            const int numberTwo = 4;
            const int numberThree = 5;

            double result = (numberOne + numberTwo + numberThree) / 3;
            Console.WriteLine($"Значение первой константы |-> {numberOne}; \nЗначение второй константы |-> {numberTwo}; \nЗначение третьей константы |-> {numberThree}.");
            Console.WriteLine($"Среднее арифметическое |-> {result}");
            Console.ReadKey();
        }
    }
}
