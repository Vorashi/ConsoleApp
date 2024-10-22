using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Task_2
{
    internal class Task_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numberFirst = int.Parse(Console.ReadLine());
            double unitsFirst = Math.Abs(numberFirst % 10);
            double tensFirst = Math.Abs(numberFirst / 10);
            Console.WriteLine($"Результат: десятки - {tensFirst}, единицы - {unitsFirst}.");
        //=========================================================================================//
            Console.WriteLine("Введите число: ");
            int numberLast = int.Parse(Console.ReadLine());
            double unitsLast = Math.Abs(numberLast % 10);
            double tensLast = Math.Abs(numberLast / 10);
            Console.WriteLine($"Результат: десятки - {tensLast}, единицы - {unitsLast}.");
            Console.ReadKey();
        }
    }
}
