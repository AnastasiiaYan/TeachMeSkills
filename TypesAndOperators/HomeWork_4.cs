/* Задание 4
Напишите программу, которая будет выполнять проверку чисел на четность.
Предложите два варианта решения поставленной задачи.
*/
namespace TypesAndOperators
{
    class HomeWork_4
    {
        static void Main()
        {
            IsEven(); //первый вариант решения задачи с if/else
            IsOdd(); //второй вариант решения задачи c swich
        }

        public static void IsEven() //первый вариант решения задачи с if/else
        {
            Console.WriteLine("Данная программа проверит является ли введенное число четным.\n" +
           "Пожалуйста, введите число");
            double input = Convert.ToDouble(Console.ReadLine());
            double isEven = input % 2;
            if (isEven == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }

        public static void IsOdd() //второй вариант решения задачи c swich
        {
            Console.WriteLine("\nА это второй вариант программы.\n" +
           "Пожалуйста, введите число");
            double input = Convert.ToDouble(Console.ReadLine());
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("Число четное");
                    break;

                default: Console.WriteLine("Число нечетное");
                    break; 
            }
        }
    }
}


          