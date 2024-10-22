using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер карты: ");
            int randomCard = int.Parse(Console.ReadLine());

            switch (randomCard) {
                case 14:
                    Console.WriteLine("Карта соответствует Тузу");
                break;
                case 13:
                    Console.WriteLine("Карта соответствует Королю");
                break;
                case 12:
                    Console.WriteLine("Карта соответствует Даме");
                break;
                case 11:
                    Console.WriteLine("Карта соответствует Валету");
                break;
                case 10:
                    Console.WriteLine("Карта соответствует Десятке");
                break;
                case 9:
                    Console.WriteLine("Карта соответствует Девятке");
                break;
                case 8:
                    Console.WriteLine("Карта соответствует Восьмерке");
                break;
                case 7:
                    Console.WriteLine("Карта соответствует Семёрке");
                break;
                case 6:
                    Console.WriteLine("Карта соответствует Шестёрке");
                break;
  
                
                default: 
                    Console.WriteLine("Такой карты нет! Или это покер?");
                break;
            }

            Console.ReadKey();
        }
    }
}
