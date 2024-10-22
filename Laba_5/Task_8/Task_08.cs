using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Task_08
    {
        static void Main(string[] args)
        {
            for (int x = 30; x <= 33; x++)
            {

                for (int y = 1; y <= 5; y++)
                {
                    int result = x - y;
                    Console.WriteLine($"{x} - {y} = {result}");
                }
            }
            Console.ReadKey();
        }
    }
}
