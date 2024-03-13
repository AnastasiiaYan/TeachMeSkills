/*
Задание 3:
Дана строковая последовательность. Строки последовательности содержат только заглавные буквы латинского алфавита.
Отсортировать последовательность по возрастанию длин строк, а строки одинаковой длины – по убыванию.
*/

using System.Linq;

namespace LINQ_Task3
{
    internal class TaskExecution

    {
        static void Main()
        {
            List<string> stringList = new List<string>()
            { "ABCD", "EFG", "HIJ", "KLMN", "OPQRSTUVWXYZ" };

            var result = stringList.OrderBy(item => item.Length)
                .ThenByDescending(item => item);

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}