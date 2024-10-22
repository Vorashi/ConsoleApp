using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Task_02
    {
        delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            doubleIt doubleuser = x => x + 1;
            Console.WriteLine($"3 + 1 = {doubleuser(3)}");
            Console.ReadKey();
        }
    }
}
