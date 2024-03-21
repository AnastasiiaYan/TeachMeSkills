/*
Задание 1:
Для приложения объявить тип делегата, который ссылается на метод.
Требования к сигнатуре метода следующие:
метод не имеет входных параметров;
метод возвращает int значение.
Реализовать вызов метода с помощью делегата. Метод возвращает случайное значение от 0 до 10.
*/

namespace Delegates_Task1
{
    internal class TaskExecution
    {
        public delegate int TaskDelegate();//делегаты должны быть объявлены на уровне класса

        static void Main()
        {
            TaskDelegate example = new TaskDelegate(RandomInt);
            int solution = example();
        }

        static int RandomInt()
        {
            return new Random().Next(0, 10);
        }
    }
}