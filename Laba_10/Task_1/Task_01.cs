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
            Console.WriteLine("Введите два числа: ");
            int userNumberOne = int.Parse(Console.ReadLine());
            int userNumberTwo = int.Parse(Console.ReadLine());
            MyFirstFunction.AddNumbers(userNumberOne, userNumberTwo);
            Console.WriteLine("сумма: " + MyFirstFunction.AddNumbers(userNumberOne, userNumberTwo));
            Console.ReadKey();
        }

        class MyFirstFunction
        {
            public static int AddNumbers(int userNumberOne, int userNumberTwo) { 
                 return userNumberOne + userNumberTwo;
            }
        }
    }
}
