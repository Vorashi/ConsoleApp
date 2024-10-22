using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст для Тани: ");
            int yearTania = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите возраст для Мити: ");
            int yearMiti = int.Parse(Console.ReadLine());

            int result = (yearTania + yearMiti) / 2;
            int argymTania = result - yearTania;
            int argymMiti = result - yearMiti;
            Console.WriteLine($"Средний возраст |=> {result}");
            Console.WriteLine($"Возраст Тани отличается от среднего на |=> {argymTania} лет");
            Console.WriteLine($"Возраст Мити отличается от среднего на |=> {argymMiti} лет");
            Console.ReadKey();
        }
    }
}
