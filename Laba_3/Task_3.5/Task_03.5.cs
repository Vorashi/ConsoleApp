using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("С некоторого момента прошло 234 дня. ");
            const int dayLater = 234;
            int weekLater = dayLater / 7;
            Console.WriteLine($"Полных за этот период прошло |=> {weekLater} недели.");
            Console.ReadKey();
        }
    }
}
