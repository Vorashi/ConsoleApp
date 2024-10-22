using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA = 3;
            int numberB = 4;
            int numberC = 5;

            bool result = !(numberA && !numberB) || (numberA || !numberC);

            Console.WriteLine(result);
        }
    }
}
