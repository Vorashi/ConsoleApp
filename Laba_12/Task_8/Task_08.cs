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
            Console.WriteLine("введите кол-во строк: ");
            int userNumberFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("введите кол-во столбцов: ");
            int userNumberLast = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение множителя (аргумента): ");
            int userMnof = int.Parse(Console.ReadLine());
            int[,] userArray = FillMatrix(userNumberFirst, userNumberLast, userMnof);

            Console.WriteLine("Матрица: {0} x {1}", userNumberFirst, userNumberLast);
            for (int i = 0; i < userNumberFirst; i++) {
                for (int j = 0; j < userNumberLast; j++) {
                    Console.Write("{0} ", userArray[i,j]);
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }

        static int[,] FillMatrix(int userNumberFirst, int userNumberLast, int userMnof) {
            int[,] matrix = new int[userNumberFirst, userNumberLast];
            for (int j = 0; j < userNumberFirst; j++) {
                for (int i = 0; i < userNumberLast; i++) {
                    matrix[i, j] = userMnof * (j + 1);
                }
            }
            return matrix;
        }
    }
}
