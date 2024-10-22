using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Task_02
    {
        static void Main(string[] args)
        {
            Debug.Assert(CountSmileys("Привет:) ") == 1); 
            Debug.Assert(CountSmileys("Это смайлик :( ") == 1);
            Debug.Assert(CountSmileys("Это смайлик ;-) ") == 1);
            Debug.Assert(CountSmileys("Это не смайлик -[") == 0);

            Console.WriteLine("Тесты пройдены");

            Console.WriteLine("Введите строку для подсчёта смайликов: ");
            string userString = Console.ReadLine();

            int countSmails = CountSmileys(userString);
            Console.WriteLine($"Для строки '{userString}' имеем {countSmails} смайликов");
            Console.ReadKey();
        }

        static int CountSmileys(string userString) {
            string patterns = @"[:;][-~]?[)(\[\]]";
            return Regex.Matches(userString, patterns).Count;
        }
    }
}
