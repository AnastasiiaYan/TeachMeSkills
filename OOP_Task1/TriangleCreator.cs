namespace OOP_Task1;

public class TriangleCreator
{
    public static Triangle CreateTriangle(double sideA, double sideB, double sideC)
    {
        double[] sideLenghts = new double[] { sideA, sideB, sideC };
        Array.Sort(sideLenghts);

        if (sideA == sideB && sideA == sideC)
        {
            return new EquilateralTriangle(sideA);
        }
        else if (sideA == sideB)
        {
            return new IsoscelesTriangle(sideA, sideC);
        }
        else if (sideA == sideC)
        {
            return new IsoscelesTriangle(sideA, sideB);
        }
        else if (sideB == sideC)
        {
            return new IsoscelesTriangle(sideB, sideA);
        }
        else if (Math.Pow(sideLenghts[0], 2) + Math.Pow(sideLenghts[1], 2) == Math.Pow(sideLenghts[2], 2))
        {
            return new RightAngledTriangle(sideLenghts[0], sideLenghts[1]);
        }
        else
        {
            return new ScaleneTriangle(sideA, sideB, sideC);
        }
    }
}