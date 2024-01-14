namespace OOP_Task1;

public class Rectangle : Quadrangle
{
    private double SideA;
    private double SideB;

    public Rectangle(double SideA, double SideB)
    {
        this.SideA = SideA;
        this.SideB = SideB;
    }

    public override void CalculateArea()
    {
        Console.WriteLine($"Площадь прямоугольника равна " + SideA * SideB);
    }
}