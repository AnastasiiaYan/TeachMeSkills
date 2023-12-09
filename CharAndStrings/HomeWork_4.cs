/*Задание 4
Дана строка: “Плохой день.”
Необходимо с помощью метода substring удалить слово "плохой".
После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
Заменить последний "!" на "?"
*/

using System;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CharAndStrings
{
    class HomeWork_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Данная программа ясные дни оставляет себе, а хмурые дни возвращает судьбе.");
            string originalDay = "Плохой день.";
            string badDay = "Плохой";
            string noBadDay = originalDay.Substring(badDay.Length);
            string addGoodDay = noBadDay.Insert(0, "Хороший");
            string gladGoodDay = addGoodDay.Insert(addGoodDay.Length - 1, "!!!!!!!!!");
            string isgladDay = gladGoodDay.Insert(gladGoodDay.Length - 1, "?");

            Console.WriteLine($"Исходный день: {originalDay}");
            Console.WriteLine($"Убираем плохой: {noBadDay}");
            Console.WriteLine($"Добавляем хороший и радуемся (точка в задании остается): {gladGoodDay}");
            Console.WriteLine($"Но есть сомнения: {isgladDay}");

        }
    }
}