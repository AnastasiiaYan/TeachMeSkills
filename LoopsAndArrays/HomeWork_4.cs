/*Задание 4
Создайте 2 массива из 5 чисел.
Выведите массивы на консоль в двух отдельных строках.
Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
*/

using System;

namespace LoopsAndArrays
{
    class HomeWork_4
    {
        static void Main()
        {
            CompareArrays();
        }

        public static void CompareArrays()
        {
            Console.WriteLine("Данная программа выявит бОльшее cреднее арифметическое среди двух массивов:");

            int[] firstarray = { 1, 2, 3, 5, 5595 };
            for (int i = 0; i < firstarray.Length; i++)
            {
                Console.Write($"{firstarray[i]} ");
            }
            
            Console.WriteLine();

            int[] secondarray = { 1, 2, 3, 5, 555 };
            for (int i = 0; i < secondarray.Length; i++)
            {
                Console.Write($"{secondarray[i]} ");
            }

            Console.WriteLine($"\nСреднее арифметическое первого массива - {firstarray.Average()}");
            Console.WriteLine($"Среднее арифметическое второго массива - {secondarray.Average()}");

            if (firstarray.Average() > secondarray.Average()) 
            {
                Console.WriteLine($"\nСреднее арифметическое первого массива больше - {firstarray.Average()}");
            }
            else if  (firstarray.Average() < secondarray.Average())
            {
                Console.WriteLine($"Среднее арифметическое второго массива больше - {secondarray.Average()}");
            }
        }
    }
}

