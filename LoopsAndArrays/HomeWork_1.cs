/*Задание 1
Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. Пусть число для поиска задается с консоли.
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopsAndArrays
{
    class HomeWork_1
    {
        static void Main()
        {
            IsInclude();
        }


        public static void IsInclude()
        {
            int[] numbers = { 1, 2, 3, 5, 55 };
            bool IsInclude = false;

            Console.WriteLine("Данная программа проверяет наличие числа в массиве.\nПожалуйста, введите число, которое нужно проверить");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == input)
                {
                    IsInclude = true;
                    break;

                }
            }
            Console.WriteLine("\n");

            if (IsInclude)
                Console.WriteLine($"Число {input} найдено в массиве!");
            else
                Console.WriteLine($"Число {input} в массиве не найдено.");
        }
    }
}