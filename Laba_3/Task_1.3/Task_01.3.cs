using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задаём константы для цены за килограмм
            const double candyPrice = 19.45;
            const double cookiesPrice = 12.23;
            const double applePrice = 21;
            // Выведем их для удобства пользователя
            Console.WriteLine($"Цена за 1 кг конфет |=> {candyPrice} \nЦена за 1 кг печенья |=> {cookiesPrice} \nЦена за 1 кг яблок |=> {applePrice}");
           
            // Спрашиваем сколько но купил кг конфет?
            Console.WriteLine("Введите сколько килограммов конфет вы купили: ");
            double numberOne = double.Parse(Console.ReadLine());

            // Спрашиваем сколько но купил кг печенья?
            Console.WriteLine("Введите сколько килограммов печенья вы купили:");
            double numberTwo = double.Parse(Console.ReadLine());

            // Спрашиваем сколько но купил кг яблок?
            Console.WriteLine("Введите сколько килограммов яблок вы купили: ");
            double numberThree = double.Parse(Console.ReadLine());

            //Считаем общую сумму за все товары
            double result = (candyPrice * numberOne) + (cookiesPrice * numberTwo) + (applePrice * numberThree);
            Console.WriteLine($"Сумма покупки равна |=> {result} руб.");
            Console.ReadKey();
        }
    }
}
