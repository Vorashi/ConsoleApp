using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Task_04
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "Ivan", "John", "Boris", "Bony"};
            Console.WriteLine("Список: ");
            foreach (var item in stringList) {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("результат 1: ");
            var Nstring = stringList.Where(x =>  x.EndsWith("n")).ToList();
            foreach (var item in Nstring) {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("результат 2: ");
            var Bostring = stringList.Where(x =>  x.StartsWith("Bo")).ToList();
            foreach (var item in Bostring)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
