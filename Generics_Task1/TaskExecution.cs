/*
Задание 1:
Реализовать класс Point, который определяет точку на координатной плоскости. В классе реализовать:
внутренние поля x, y;
конструктор с 2 параметрами;
свойства доступа к внутренним полям класса;
метод, выводящий значения внутренних полей класса.
*/
using Generics_Task1;
using System.Drawing;

namespace Generics_Task1;
internal class TaskExecution
{
    static void Main()
    {
        Point <string> stringType = new Point<string>("a", "b");
        Point <int> intType = new Point<int>(1, 2);
        stringType.Print();
        intType.Print();
    }
}