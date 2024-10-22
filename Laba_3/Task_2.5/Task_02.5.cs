using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для X:");
            int numberX = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение для Y:");
            int numberY = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение для Z:");
            int numberZ = int.Parse(Console.ReadLine());

            Console.WriteLine("Наша формула |=> x = y - x++ * z");
            numberX = numberY - numberX++ * numberZ;
            Console.WriteLine($"Значение переменной X после операций |=> {numberX}");
            Console.WriteLine($"Значение переменной Y после операций |=> {numberY}");
            Console.WriteLine($"Значение переменной Z после операций |=> {numberZ}");
            Console.ReadKey();
        }
    }
}
