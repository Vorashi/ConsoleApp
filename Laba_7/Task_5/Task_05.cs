using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Task_05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число: ");
            int userNumber = int.Parse(Console.ReadLine());

            ChangeDigits(userNumber);
            Console.ReadKey();
        }

        static void ChangeDigits(int userNumber) {
            int reversResult = (userNumber % 10) * 10 + (userNumber / 10);
            Console.WriteLine($"Результат: {reversResult}");
        }
    }
}
