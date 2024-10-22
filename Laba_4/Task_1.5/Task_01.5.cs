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
            int resistanceFirst = 15; // Сопротивление
            int resistanceLast = 20;

            double voltageFirst = 10.6; // Напряжение
            double voltageLast = 12.8;

            double resultCurrentFirst = resistanceFirst / voltageFirst; // I = U / R;
            double resultCurrentLast = resistanceLast / voltageLast; // Нашли Силу Тока

            if (resistanceFirst > resistanceLast) {
                Console.WriteLine("Меньший ток протекает по второму участку");
            } else if (resistanceFirst < resistanceLast) {
                Console.WriteLine("Меньший ток протекает по первому участку");
            } else {
                Console.WriteLine("Ток равен на всех участках");
            }
            Console.ReadKey();
        }
    }
}
