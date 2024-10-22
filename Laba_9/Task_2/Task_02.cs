using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Task_02
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[15];
            CreatRandomArray(integerArray);
            Console.WriteLine("введите искомое значение: ");
            int userNumber = int.Parse(Console.ReadLine());
            UserNumberSearh(integerArray, userNumber);
            Console.ReadKey();
        }

        static void CreatRandomArray(int[] integerArray) {
            Random random = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < integerArray.Length; i++) {
                Console.Write($" { integerArray[i] = random.Next(1, 10) } ");
            }
            Console.WriteLine();
        }

        static void UserNumberSearh(int[] integerArray,int userNumber) {
            int counter = 0;
            bool searchNumber = false;
            for (int i = 0; i < integerArray.Length; i++) {
                if (integerArray[i] == userNumber) {
                    Console.Write("Да! ");
                    searchNumber = true;
                    Console.WriteLine();
                    Console.WriteLine($"Индекс числа в массиве = {counter}");
                    break;
                } 
                counter++;
            }
                if (searchNumber != true) {
                    Console.Write("Нет! ");
                }
        }
    }
}
