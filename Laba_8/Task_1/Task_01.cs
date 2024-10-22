using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1
{
    internal class Task_01
    {
        enum DayOfWeek
        { ПН = 1, ВТ, СР, ЧТ, ПТ, СБ, ВС = 7 }

        static void PrintDayOfWeek(DayOfWeek dow)
        {
            switch (dow)
            {
                case DayOfWeek.ПН:Write("Понедельник");
                    break;
                case DayOfWeek.ВТ:Write("Вторник");                 
                    break;
                case DayOfWeek.СР:Write("Среда");
                    break;
                case DayOfWeek.ЧТ:Write("Четверг");
                    break;
                case DayOfWeek.ПТ: Write("Пятница");
                    break;
                case DayOfWeek.СБ:Write("Суббота");
                    break;
                case DayOfWeek.ВС:Write("Воскресенье");
                    break;
                default:Write("Некорректное значение дня недели");
                    break;
            }
        }

        static DayOfWeek ReadDayOfWeek()
        {
            while (true)
            {
                Write("Введи день недели (от 1 до 7 или название дня): ");
                string input = ReadLine();

                if (int.TryParse(input, out int day) && day > 0 && day < 8)
                {
                    return (DayOfWeek)day;
                }
                else if (Enum.TryParse(input, out DayOfWeek dow))
                {
                    return dow;
                }
                else
                    Write("Некорректный ввод. Пожалуйста, повтори попытку.");
            }
        }

        static void Main()
        {
            DayOfWeek dow = ReadDayOfWeek();
            PrintDayOfWeek(dow);
            ReadKey();
        }
    
    }
    
}
