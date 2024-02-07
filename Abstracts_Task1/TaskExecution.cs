/*
Задание 1:
Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
Реализовать метод подсчета площади и периметра для каждого типа фигуры.
Создать массив из 5 фигур.
Вывести на экран сумму периметра и площади всех фигур в массиве.
*/
using System.Drawing;
using System.Text;

namespace Abstract_Task1;

internal class TaskExecution
{
    static void Main()
    {
        Figure[] taskFigures = new Figure[5];
        taskFigures[0] = new Triangle(3, 3, 3);
        taskFigures[1] = new Rectangle(10, 9);
        taskFigures[2] = new Rectangle(15, 6);
        taskFigures[3] = new Сircle(1);
        taskFigures[4] = new Сircle(6);

        float sumOfPerimeter = 0;
        float sumOfArea = 0;

        foreach (Figure figure in taskFigures)
        {
            sumOfPerimeter += figure.GetPerimeter();
            sumOfArea += figure.GetArea();
        }

        Console.WriteLine($"Cумма периметра и площади всех фигур в массиве:{sumOfPerimeter + sumOfArea}");
    }
}