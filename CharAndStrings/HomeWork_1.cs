/*Задание 1
Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.

Примечание:
Данные для задач могут быть проинициализированы непосредственно в задаче, введены через терминал или (*) прочитаны из подготовленного файла./using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
*/

using System.Text.RegularExpressions; // для Regex

namespace CharAndStrings
{
    class HomeWork_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа анализирует текст, удаляет все цифры и делает замену 'test' на 'testing'.");
            string originalText = "test, 2, МТС, 5,task, test"; 
            Console.WriteLine($"Было: {originalText}");
            string redactText = redact(originalText);
            Console.WriteLine($"Стало: {redactText}");
        }


        public static string redact(string originalText) // сигнатура static string, чтобы указать, что  принимает строку в качестве аргумента и возвращает исправленную строку.
        {
            string removeNum = Regex.Replace(originalText, @"\d+", ""); //Символ \d в регулярном выражении обозначает любую цифру от 0 до 9. Знак + указывает на то, что цифровой символ может повторяться один или более раз.
            string redact = removeNum.Replace("test", "testing");
            return redact;
        }
    }
}



