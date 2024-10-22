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
            int argsMounth = 12;
            bool resultSummer = (argsMounth >= 6 && argsMounth <= 8) ? true : false;
            bool resultWinter = (argsMounth > 3 && argsMounth == 12) ? true : false;
            bool resultAutumn = (argsMounth >= 9 && argsMounth < 12) ? true : false;
            bool resultSpring = (argsMounth >= 3 && argsMounth < 6) ? true : false;

            Console.WriteLine($"Этот месяц входит в Лето: {resultSummer}");
            Console.WriteLine($"Этот месяц входит в Зиму:{resultWinter}");
            Console.WriteLine($"Этот месяц входит в Осень:{resultAutumn}");
            Console.WriteLine($"Этот месяц входит в Весну:{resultSpring}");
            Console.ReadKey();
        }
    }
}
