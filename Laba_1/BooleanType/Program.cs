using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a<b && b<c);
            Console.ReadKey();
        }
    }
}
