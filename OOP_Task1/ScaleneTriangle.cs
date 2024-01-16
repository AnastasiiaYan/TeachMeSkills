namespace OOP_Task1;

public class ScaleneTriangle : Triangle
{
   private double sideA;
   private double sideB;
   private double sideC;

   public ScaleneTriangle(double sideA, double sideB, double sideC)
   {
    this.sideA = sideA;
    this.sideB = sideB;
    this.sideC = sideC;
   }
   
   public override void CalculateArea()
    {
      double p = (sideA + sideB + sideC) / 2;
      Console.WriteLine($"Площадь разностороннего треугольника равна " + Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));
    }
}