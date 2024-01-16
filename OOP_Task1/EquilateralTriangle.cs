namespace OOP_Task1;

public class EquilateralTriangle : Triangle
{
    private double sideLenght;

    public EquilateralTriangle(double sideLenght)
    {
        this.sideLenght = sideLenght;
    }

    public override void CalculateArea()
    {
        Console.WriteLine($"Площадь равностороннего треугольника равна " + Math.Pow(sideLenght, 2) * Math.Sqrt(3) / 4);
    }
}