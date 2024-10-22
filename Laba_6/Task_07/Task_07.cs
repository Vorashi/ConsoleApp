using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;


namespace Task_07
{
    internal class Task_07
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 3) {
                Console.Write("Введите значение x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Введите значение y: ");
                int y = int.Parse(Console.ReadLine());
                
                bool isWhite = (x - y) % 2 == 0;
                Console.WriteLine($"Этот квадрат белый: {isWhite}");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
