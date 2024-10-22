using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Task_05
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int pageNumber = 0;
            int i = 0;
            int userNumber;
            do
            {
                i++;
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber > max)
                {
                    max = userNumber;
                    pageNumber = i;
                }
            } while (userNumber != 0);
            Console.WriteLine($"максимальное число |=> {max}, его порядковый номер |=> {pageNumber}.");
            Console.ReadKey();
        }
    }
}
