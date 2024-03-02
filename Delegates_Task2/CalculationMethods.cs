using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Task2
{
    internal class CalculationMethods
    {
        public double Lenth(double r)
        {
            double result = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности: {result}");
            return result;
        }

        public double Area(double r)
        {
            double result = Math.PI * r * r;
            Console.WriteLine($"Площадь круга: {result}");
            return result;
        }

        public double Volume(double r)
        {
            double result = (4 / 3) * Math.PI * r * r * r;
            Console.WriteLine($"Объем шара: {result}");
            return result;
        }
    }
}
