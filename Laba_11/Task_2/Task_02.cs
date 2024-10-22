using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_2.Task_02;

namespace Task_2
{
    internal class Task_02
    {
        static void Main(string[] args)
        {
            int[] result1 = Minimum.FindMin(5, 3, 6);
            Console.WriteLine("результат с тремя параметрами (5, 3, 6): ");
            for (int i = 0; i < result1.Length; i++) {
                Console.WriteLine($"{result1[i]}");
            }
            int[] nums = { 5, 3, 3, 6, 5 };
            int[] result2 = Minimum.FindMin(nums);
            Console.WriteLine("результат с целочисленным массивом ( 5, 3, 3, 6, 5 ): ");
            for (int i = 0; i < result2.Length; i++) {
                Console.WriteLine(result2[i]);
            }
            Console.ReadKey();
        }


    public static class Minimum {

        public static int[] FindMin(params int[] numbers)
        {
            int min = numbers[0];
            foreach (int i in numbers) {
                if (i < min) { 
                min = i;
                }    
            }
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] == min) {
                numbers[i] = 0;   
                }
            }
            return numbers;
        }
    }
    
}
}
