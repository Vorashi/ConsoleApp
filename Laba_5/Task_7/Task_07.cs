using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Task_07
    {
        static void Main(string[] args)
        {
            for (int x = 2; x <= 5; x++) {

                for (int y = 2; y <= 4; y++) {
                    Console.WriteLine($"z(x,y) = {x}^{y} = {Math.Pow(x,y)}");
                }
            }
            Console.ReadKey();
        }
    }
}
