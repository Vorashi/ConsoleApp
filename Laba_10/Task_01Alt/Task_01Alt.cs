using System;
namespace Task_01Alt
{
    internal class Task_01Alt
    {
        public class Function {
            public static Func<int, int, int> Lambda = (x, y) => x + y;
        }
        
        static void Main()
        {
            Console.WriteLine("Введите два числа: ");
            int userNumberOne = int.Parse(Console.ReadLine());
            int userNumberTwo = int.Parse(Console.ReadLine());
            Function.Lambda(userNumberOne, userNumberTwo);
            int sum = Function.Lambda(userNumberOne,userNumberTwo);
            Console.WriteLine("сумма: " + Function.Lambda(userNumberOne, userNumberTwo));
            Console.ReadKey();
        }
    }
}
