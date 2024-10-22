using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Task_07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность, завершите ввод 0: ");
            int plusNumber = 0;
            int minusNumber = 0;
            int counter = 0;
            int userNumber = 0;
            do {
                counter++;
                userNumber = int.Parse(Console.ReadLine());
                PosNegSeq(ref plusNumber, ref minusNumber, ref userNumber);
            } while (userNumber != 0 );

            Console.WriteLine($"количество отрицательных: {plusNumber}, количество положительных: {minusNumber}");
            Console.ReadKey();
        }

        static void PosNegSeq(ref int plusNumber,ref int minusNumber, ref int userNumber) {
            if (userNumber > 0) {
                plusNumber++;
            } else if (userNumber <= -1) {
                minusNumber++;
            }
        }
    }
}
