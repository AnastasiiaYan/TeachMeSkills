/*Задание 2
Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
Welcome to the TMS lessons.
Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
*/

using System;

namespace CharAndStrings
{
    class HomeWork_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(concatenation());
        }


        public static string concatenation()
        {
            string welcome = "Welcome";
            string to = "to";
            string the = "the";
            string TMS = "TMS";
            string lessons = "lessons";

            string concatenation = String.Concat(welcome, " ", to, " ", the, " ", TMS, " ", lessons);
            return concatenation;

        }
      
    }
}




