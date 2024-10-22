using System;
using System.Diagnostics;

namespace Task_1
{
    class Task_01
    {
        static void Main(string[] args)
        {
            
            Debug.Assert(CheckDateFormat("12/03/1975") == false);
            Debug.Assert(CheckDateFormat("2-3-1975") == false);
            Debug.Assert(CheckDateFormat("12-03-1975") == true);

            Console.WriteLine("Тесты пройдены корректно");

            Console.WriteLine("Пожалуйста, введите дату в формате dd-mm-yyyy:");
            string userInputDate = Console.ReadLine();

            if (CheckDateFormat(userInputDate)) {
                Console.WriteLine("Формат даты верный");
            } else {
                Console.WriteLine("Формат даты неверный");
            }
            Console.ReadKey();
        }

        static bool CheckDateFormat(string userInputDate)
        {
            if (userInputDate.Length != 10) {
                return false;
            }

            if (userInputDate[2] != '-' || userInputDate[5] != '-') {
                return false;
            }

            for (int i = 0; i < userInputDate.Length; i++) {
                if (i == 2 || i == 5) {
                    continue; 
                }

                if (!Char.IsDigit(userInputDate[i])) {
                    return false;
                }
            }
            return true;
        }
    }
}
