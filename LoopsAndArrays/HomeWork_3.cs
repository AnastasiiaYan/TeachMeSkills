/*Задание 3
Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
Для генерации случайного числа используйте метод Random() . Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.
*/

using System;

namespace LoopsAndArrays
{
    class HomeWork_3
    {
        static void Main()
        {
            FindMinMax();
        }

        public static int[] CreateRandomArray(int arraylength)
        {
            int[] content = new int[arraylength];
            Random random = new Random();

            for (int i = 0; i < content.Length; i++)
            {
                content[i] = random.Next();
            }

            return content;
        }
        public static void FindMinMax()
        {
            Console.WriteLine("Данная программа выведет максимальное и мимнимальное значение массива. " +
                "\nВведите число - оно будет являться длиной массива");

            int arraylength = Int32.Parse(Console.ReadLine());
            int[] arrayСontent = CreateRandomArray(arraylength);
            Console.WriteLine($"Максимальное число массива - {arrayСontent.Max()}");
            Console.WriteLine($"Минимальное число массива - {arrayСontent.Min()}");
            Console.WriteLine("Весь массив:");
            for (int i = 0; i < arraylength; i++)
            {
                Console.WriteLine(arrayСontent[i]);
            }

        }
    }
}

