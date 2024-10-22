using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = 389;
            Console.WriteLine($"Начальное число до переворота |=> {randomNumber}");
            
            int hungreds = randomNumber / 100;
            int tens = (randomNumber / 10) % 10;
            int ones = randomNumber % 10;
            int reversNumber = ones * 100 + tens * 10 + hungreds;

            Console.WriteLine($"Наше перевернутое число |=> {reversNumber}");
            Console.ReadKey();
        }
    }
}
