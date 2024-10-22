using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Task_01
    {
        static void Main(string[] args)
        {
            string surname = "Sharov";
            string name = "Matvei";
            string gateBirhday = "19.01.2005";
            string adress = "Russia, Rybinsk";
            string nameCurs = "IS - 3";
            string balls = "76";
            string workDay = "26";
            string teacher = "Екатерина Андреевна Кустова";

            Console.WriteLine($"Информация о студенте:  \n Имя: {name} \n Фамилия: {surname} \n Дата рождения: {gateBirhday} \n Адрес: {adress} \n Информация о курсе: \n Название курса: {nameCurs} \n Баллы: {balls} \n Количество занятий в неделю: {workDay} \n Преподаватель: {teacher} ");;
            Console.ReadKey();
        }
    }
}
