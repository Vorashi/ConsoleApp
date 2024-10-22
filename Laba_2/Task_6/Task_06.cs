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
            Console.WriteLine("Введите число: ");
            int numberFirst = int.Parse(Console.ReadLine());
            double result = 0;
            if ( numberFirst > -2 || numberFirst > 2 ) {
                result = numberFirst * 2;
            } else if (numberFirst < -2 || numberFirst > 2) { 
                result = numberFirst * (- 3);
            } else { // Как учил Жебраков делаем все возможные варианты!
                Console.WriteLine("ТЫ КТО ТАКОЙ, ЧТОБЫ ТАКОЕ СДЕЛАТЬ!?");
            }
            //Выводим итог нашего ветвления
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}
