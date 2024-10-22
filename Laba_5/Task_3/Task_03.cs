using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Task_03
    {
        static void Main(string[] args)
        {
            int plusNumber = 0;
            int minusNumber = 0;
            Console.WriteLine("Введите 10 чисел: ");
            for (int i = 0; i <= 10; i++) { 
            int userNumbers = int.Parse(Console.ReadLine());
                
                if (userNumbers >= 0) {
                    plusNumber++;
                } else {
                    minusNumber++;
                }
            }
            Console.WriteLine($"|=> Положительных чисел:{plusNumber}, отрицательных чисел:{minusNumber}");
            Console.ReadKey();
        }
    }
}
