/*Задание 3
Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
Результат вывести в консоль.
*/

using System;
using static System.Net.Mime.MediaTypeNames;

namespace CharAndStrings
{
    class HomeWork_3
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Данная программа поделит исходный текст на 2 строки согласно условию");
            string original = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            string[] trigger = original.Split("abc"); //https://learn.microsoft.com/ru-ru/dotnet/csharp/how-to/parse-strings-using-split

            string firstpiece = trigger[0];
            string secundpiece = trigger[1];

            Console.WriteLine($"Исходный текст: {original}");
            Console.WriteLine($"Первая часть до 'abc': {firstpiece}");
            Console.WriteLine($"Вторая часть: {secundpiece}");


            
        }
                     
    }
}




