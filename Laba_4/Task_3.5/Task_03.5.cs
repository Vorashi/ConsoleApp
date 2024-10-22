using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ternaryNumber = 146;
            int variableA = 23;

            int hundreds = ternaryNumber / 100;
            int tens = (ternaryNumber / 10) % 10;
            int ones = ternaryNumber % 10;

            int resultTernary = hundreds + tens + ones;

            if (variableA == resultTernary) {
                Console.WriteLine("Сумма тернарного числа равна переменной А");
            } else {
                Console.WriteLine("Сумма тернарного числа не равна переменной А");
            }
            Console.ReadKey();
        }
    }
}
