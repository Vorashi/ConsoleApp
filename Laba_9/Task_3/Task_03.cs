using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Task_03
    {
        static void Main(string[] args)
        {
            double[] integerArray = new double[10];
            Console.WriteLine("Массив: ");
            CreatRandomArray(integerArray);
            Console.WriteLine("суммы троек: ");
            ArrayThreeSum(integerArray);
            Console.ReadKey();
        }

        static void CreatRandomArray(double[] integerArray)
        {
            Random random = new Random();
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = random.NextDouble() * 10 - 5;
                Console.Write(" {0:0.00} ", integerArray[i]);
            }
            Console.WriteLine();
        }

        static void ArrayThreeSum(double[] integerArray) {
            for (int i = 0; i < integerArray.Length - 2; i++)
            {
                double sumThreeNumbers = integerArray[i] + integerArray[i + 1] + integerArray[i + 2];
                Console.Write(" {0:0.00} ", sumThreeNumbers);
            }
        }

    }
}
