/*
Задание 3:
Для приложения объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
метод имеет входной параметр типа int[];
метод возвращает значение типа int[].
Дополнительно создать enum с типами сортировки (не менее 2-ух)
Реализовать метод, который на основании типа сортировки возвращает тип делегата.
Основная программа выполняет сортировку случайно сгененированного массива на основании выбранного типа.
*/

using Helper;
using static Delegates_Task3.Sort;

namespace Delegates_Task3
{
    internal class TaskExecution
    {
        static void Main()
        {
            Random random = new Random();
            int[] randomArray = Enumerable.Range(0, 10).Select(i => random.Next(100)).ToArray();
            PrintHelper.PrintArray(randomArray);

            SortTypes sortType = SortTypes.SortAscend;
            Sort sort = new Sort();
            sortDelegate sortDelegate = sort.GetSortDelegate(sortType);
            int[] sortedArray = sortDelegate(randomArray);
            PrintHelper.PrintArray(sortedArray);
        }
    }
}