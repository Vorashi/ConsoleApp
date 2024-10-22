using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_15
{
    internal class Task_01
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.AddRange(Enumerable.Range(-5, 16));

            foreach (var item in numberList) {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
