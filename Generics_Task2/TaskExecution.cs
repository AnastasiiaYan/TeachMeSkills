/*
Задание 2:
Напишите обобщенный класс, который может хранить в массиве объекты любого типа. 
Также, данный класс должен иметь методы для добавления данных в массив, удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.
Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
*/

namespace Generics_Task2;
internal class TaskExecution
{
    static void Main()
    {
        ArrayContainer<int> сontainerInt = new ArrayContainer<int>();

        сontainerInt.Add(1);
        сontainerInt.Add(2);
        сontainerInt.Remove(0);
        сontainerInt.Find(0);
        сontainerInt.Length();

        ArrayContainer<string> сontainerStr = new ArrayContainer<string>();
        сontainerStr.Add("5");
        сontainerStr.Add("TEST");
        сontainerStr.Remove(0);
        сontainerStr.Find(0);
        сontainerStr.Length();
    }
}