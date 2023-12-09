/*Задание 2
Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
В результате должен быть новый массив без указанного числа.
*/

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopsAndArrays
{
    class HomeWork_2
    {
        static void Main()
        {
            DropInclude();
        }


        public static void DropInclude()
        {
            int[] numbers = { 1, 2, 3, 5, 55 };

            Console.WriteLine("Данная программа проверяет наличие числа в массиве. " +
                "Если число есть - оно будет удалено.\nНиже представлен массив, пожалуйста, введите число, которое нужно удалить");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            int input = Convert.ToInt32(Console.ReadLine());


            if (Array.IndexOf(numbers, input) != -1) //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/indexOf
            {
                while (Array.Exists(numbers, element => element == input))
                {
                    int index = Array.IndexOf(numbers, input);
                    int lenth = numbers.GetLength(0) - index - 1;

                    Array.Copy(numbers, index + 1, numbers, index, lenth);
                    Array.Resize(ref numbers, numbers.GetLength(0) - 1);
                }
            Console.WriteLine($"Из массива удалено число: {input}, теперь массив выглядит следующим образом:");
            foreach (int arrayElement in numbers)
                Console.Write($"{arrayElement} "); }

            else
            {
             Console.WriteLine("Вееденное число в массиве не найдено. Перезапустите программу для повтора операции.");
            }
        }
    }
}



