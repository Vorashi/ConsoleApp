using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Task_02
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[10];
            int counter = 0;
            MyFunction.RandomArrayGenerator(randomArray);
            MyFunction.PrintArray(randomArray);
            MyFunction.EvenArray(randomArray, out counter);
            Console.ReadKey();
        }

        class MyFunction {

            public static void RandomArrayGenerator(int[] randomArray) { 
                Random random = new Random();
                for (int i = 0; i < randomArray.Length; i++) {
                    randomArray[i] = random.Next(-10,10);
                }
            }

            public static void PrintArray(int[] randomArray) {
                Console.WriteLine("Массив: ");
                for (int i = 0; i < randomArray.Length; i++) {
                    Console.Write($"{randomArray[i]} ");
                }
                Console.WriteLine("");
            }

            public static void EvenArray(int[] randomArray, out int counter) {
                Console.WriteLine("четные элементы: ");
                counter = 0;
                for (int i = 0; i < randomArray.Length; i++) {
                    if (randomArray[i] % 2 == 0) {
                        Console.Write($"{randomArray[i]},");
                        Console.Write($" index: {++counter}");
                        Console.WriteLine("");
                    }
                }
            }


        }
    }
}
