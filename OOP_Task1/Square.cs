namespace OOP_Task1;

public class Square : Quadrangle
{
    private double Side;

    public Square(double side)
    {
        this.Side = side;
    }

    public override void CalculateArea()
    {
        Console.WriteLine($"Площадь квадрата равна " + Side * Side);
    }
}