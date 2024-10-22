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
            Console.WriteLine("Введите число от 1 до 7: ");
            int numberFirst = int.Parse(Console.ReadLine());
            switch (numberFirst) {
                case 1: Console.WriteLine("Результат: 1 - й день недели это Понедельник! ");
                    break;
                case 2: Console.WriteLine("Результат: 2 - й день недели это Вторник! ");
                    break;
                case 3: Console.WriteLine("Результат: 3 - й день недели это Среда! ");
                    break;
                case 4: Console.WriteLine("Результат: 4 - й день недели это Четверг! ");
                    break;
                case 5: Console.WriteLine("Результат: 5 - й день недели это Пятница! ");
                    break;
                case 6: Console.WriteLine("Результат: 6 - й день недели это Суббота! ");
                    break;
                case 7: Console.WriteLine("Результат: 7 - й день недели это Воскресенье! ");
                    break;
                default: Console.WriteLine("Извините, но такого дня недели не существует!?");
                    break;
            }
//======================================================================================================//
            Console.WriteLine("Введите число от 1 до 7: ");
            int numberLast = int.Parse(Console.ReadLine());
            switch (numberLast) {
                case 1:
                    Console.WriteLine("Результат: 1 - й день недели это Понедельник! ");
                    break;
                case 2:
                    Console.WriteLine("Результат: 2 - й день недели это Вторник! ");
                    break;
                case 3:
                    Console.WriteLine("Результат: 3 - й день недели это Среда! ");
                    break;
                case 4:
                    Console.WriteLine("Результат: 4 - й день недели это Четверг! ");
                    break;
                case 5:
                    Console.WriteLine("Результат: 5 - й день недели это Пятница! ");
                    break;
                case 6:
                    Console.WriteLine("Результат: 6 - й день недели это Суббота! ");
                    break;
                case 7:
                    Console.WriteLine("Результат: 7 - й день недели это Воскресенье! ");
                    break;
                default:
                    Console.WriteLine("Извините, но такого дня недели не существует!?");
                    break;
            }
            Console.ReadKey();
        }
    }
}
