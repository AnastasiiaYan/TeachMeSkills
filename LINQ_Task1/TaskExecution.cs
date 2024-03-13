/*
 * Задание 1:
Дана целочисленная последовательность. 
Извлечь из нее все нечетные числа, сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.
*/
using System.Linq;

namespace LINQ_Task1
{
    internal class TaskExecution
    {
        static void Main()
        {
            Random random = new Random();
            int[] randomArray = Enumerable.Range(0, 6).Select(i => random.Next(6)).ToArray();
            PrintHelper.PrintArray(randomArray);

            var oddArray = randomArray.Where(n => n % 2 != 0).Distinct().ToArray();
            PrintHelper.PrintArray(oddArray);
        }
    }
}