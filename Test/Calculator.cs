using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Task1
{
    internal class Calculator
    {
        public int Div(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }

    public double Div(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
    }
}
