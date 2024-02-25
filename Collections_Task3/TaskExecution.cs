/*Задание 3:
Коллекция содержит набор чисел в виде одной строки "1, 2, 3, 4, 4, 5". 
Избавиться от повторяющихся элементов в строке и вывести результат на экран.
*/

namespace Collections_Task3;
public class TaskExecution
{
    static void Main()
    {
        List<string> numbersList = new List<string>() { "1 2, 3, 4, 4, 5" };
        string[] numbersArray = numbersList[0].Split(", "); //не могу убрать повтор пока не разделю строку
        var hashset = new HashSet<string>(numbersArray);

        foreach (var num in hashset)
        {
            Console.Write($"{num}, ");
        }
    }
}