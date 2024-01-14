namespace OOP_Task1;

public class IsoscelesTriangle : Triangle
{
    private double sideLenght;
    private double baseLenght;

    public IsoscelesTriangle(double sideLenght, double baseLenght)
    {
        this.sideLenght = sideLenght;
        this.baseLenght = baseLenght;
    }
    
    public override void CalculateArea()
    {
        Console.WriteLine($"Площадь равнобедренного треугольника равна " +
        baseLenght / 4 * Math.Sqrt(4 * Math.Pow(sideLenght, 2) - Math.Pow(baseLenght, 2)));
    }
}