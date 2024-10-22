using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainArrivalHours = 10; // Прибытие поезда
            int trainArraivalMinutes = 45;

            int trainDepartureHours = 11; // Отбытие поезда
            int trainDepartureMinutes = 45;

            int PassengerArrivalHours = 11; // Прибытие пассажира
            int PassengerArrivalMinutes = 25;


            if (trainArrivalHours <= PassengerArrivalHours || trainDepartureHours >= PassengerArrivalHours && trainArraivalMinutes < PassengerArrivalMinutes || trainDepartureMinutes < PassengerArrivalMinutes) {
                Console.WriteLine("Пассажир успевает к отходу поезда!");
            } else { 
                Console.WriteLine("Пассажир не успеет на поезд!"); 
            }
            Console.ReadKey();
        }
    }
}
