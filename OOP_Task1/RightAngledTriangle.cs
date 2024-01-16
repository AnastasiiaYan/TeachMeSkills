namespace OOP_Task1;

public class RightAngledTriangle : Triangle
{
    private double СathetusA;
    private double СathetusB;

    public RightAngledTriangle(double СathetusA, double СathetusB)
    {
        this.СathetusA = СathetusA;
        this.СathetusB = СathetusB;
    }
    
    public override void CalculateArea()
    {
        Console.WriteLine($"Площадь прямоугольного треугольника равна " + (СathetusA * СathetusB) / 2);
    }
}
