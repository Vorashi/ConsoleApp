using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Task_08
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 8 ) {
                int j = 0;
                while (j < 8) {
                        if ((i + j) % 2 == 0) {
                            Console.Write("X");
                        } else {
                            Console.Write("O");
                        }
                        j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}
