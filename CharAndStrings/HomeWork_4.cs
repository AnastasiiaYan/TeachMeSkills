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
            // решение 1
            Console.WriteLine($"Данная программа ясные дни оставляет себе, а хмурые дни возвращает судьбе.");
            string originalDay = "Плохой день.";
            string noBadDay = originalDay.Substring(6);
            string addGoodDay = noBadDay.Insert(0, "Хороший");
            string gladGoodDay = addGoodDay.Insert(12, "!!!!!!!!!");
            string isgladDay = gladGoodDay.Insert(21, "?");

            Console.WriteLine($"Исходный день: {originalDay}");
            Console.WriteLine($"Убираем плохой: {noBadDay}");
            Console.WriteLine($"Добавляем хороший и радуемся: {gladGoodDay}");
            Console.WriteLine($"Но есть сомнения: {isgladDay}");

            // решение 2
            string str = "Плохой день.";
            string toDelite = "Плохой";
            str = str.Substring(toDelite.Length);
            string toAdd = "Хороший";
            str = str.Insert(0, toAdd);
            str = str.Insert(str.Length-1, "!!!!!!!!!");
            str = str.Insert(str.Length-1, "?");
            Console.WriteLine($"РЕШЕНИЕ 2: {str}");
        }
    }
}


/*Substring принимает 2 аргумента : начальный индекс и количество символов, которые нужно удалить.
string resultString = originalString.Substring(0, 7) + originalString.Substring(19);
Первый вызов originalString.Substring(0, 7) возвращает подстроку, начиная с индекса 0 и содержащую 7 символов. 
Второй вызов originalString.Substring(19) возвращает подстроку, начинающуюся с индекса 19 и идущую до конца строки. 
Символы от 8 до 19 будут удалены

Insert позволяет создать новую строку путем вставки подстроки в определенную позицию исходной строки.
Принимает два аргумента: позицию, в которую нужно вставить подстроку, и саму подстроку для вставки.
*/
