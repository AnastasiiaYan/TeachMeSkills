﻿/* Задание 2
       Напишите программу определения, попадает ли введенное пользователем число (от -50 до 50) в один из числовых промежутков [-40, -10][-9, 0][1, 10][11, 40].
       Если да, то укажите, в какой именно промежуток.
       Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
       */
namespace TypesAndOperators
{
    class HomeWork_2
    {
        static void Main()
        {
            CheckNumber();
        }
        private static void CheckNumber()
{
            Console.WriteLine("Данная программа проверяет в какой числовой промежуток попадает введенное число.\n" +
           "Пожалуйста, введите число от -50 до 50.");
            int input = Int32.Parse(Console.ReadLine());
            if (input > 50 | input < -50)
            {
                Console.WriteLine("Ой, ваше число " + input + " не входит в допустимый диапазон [-50, 50]");
            }
            else if (input >= -40 && input <= -10)
            {
                Console.WriteLine("Что ж, ваше число " + input + " входит в диапазон [-40, -10]");
            }
            else if (input >= -9 && input <= 0)
            {
                Console.WriteLine("Что ж, ваше число " + input + " входит в диапазон [-9, 0]");
            }
            else if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Что ж, ваше число " + input + " входит в диапазон [1, 10]");
            }
            else if (input >= 11 && input <= 40)
            {
                Console.WriteLine("Что ж, ваше число " + input + " входит в диапазон [11, 40]");
            }
            else
            {
                Console.WriteLine("Указаное число " + input + " не входит ни в один из имеющихся числовых промежутков");
            }
        }
    }
}

          