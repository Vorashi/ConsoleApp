using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Task_06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число: ");
            int userNumberOne = int.Parse(Console.ReadLine());
            int userNumberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Побитовая сумма чисел {userNumberOne} и {userNumberTwo} = " + BitwiseSum(userNumberOne, userNumberTwo));
            Console.ReadKey();
        }

        static int BitwiseSum(int userNumberOne, int userNumberTwo) {
            int firstNumberOne = userNumberOne % 10;
            int secondNumberOne = userNumberOne / 10;
            int firstNumberTwo = userNumberTwo % 10;
            int secondNumberTwo = userNumberTwo / 10;
            int resultNumberOne = 0; 
            int resultNumberTwo = 0;
            int userSum = 0;

            resultNumberOne = (firstNumberOne + firstNumberTwo) % 10;
            resultNumberTwo = (secondNumberOne + secondNumberTwo) % 10;
            userSum = resultNumberTwo * 10 + resultNumberOne ;

            return userSum;
        }
    }
}
