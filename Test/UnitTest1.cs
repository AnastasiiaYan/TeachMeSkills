/*
������� 1:
����������� ��� ������ Div(int a, int b) and Div(double a, double b) � ������ Calculator
�������� ����� �� ��������� ������ ������� � �������������� ���� ��������� ���������. ����������� ��������� ������� �� 0.
�������:
- ���� ��� ������� �� 0
- ���� ��� ������� ���� ������������� ����� / ������������ �����
- ���� ��� ������� ������ �������������� � ������ �������������� ������/������������ �����
- ���� ��� ������� ���� ������������� ����� / ������������ �����
- ���� ������� ����� �� ������ ���� ��� ����� / ������������ �����
*/
using NUnit_Task1;
using System;

[TestFixture, Category("Calculator")]
[Author("A_YANOVNA")]

public class UnitTest1
{
    private Calculator _calculator;
    int a;
    int b;
    double c;
    double d;

    [SetUp]
    public void Setup()
    {
        Random random = new Random();
        a = random.Next(1);
        b = 2;
        c = random.Next(1);
        d = 0.5;
        _calculator = new Calculator();
    }

    [Test]
    [Description("���� ��� ������� �� 0 int"), Order(1)]
    public void DivZeroInt()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Div(a, 0));
    }

    [Test]
    [Description("���� ��� ������� �� 0 double"), Order(2)]
    public void DivZeroDouble()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Div(c, 0.0));
    }

    [Test]
    [Description("���� ��� ������� ���� ������������� ����� �����"), Order(3)]
    public void DiviTwoPositiveInt()
    {
        int expected = a / b;
        int actual = _calculator.Div(a, b);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    [Description("���� ��� ������� ������ �������������� ������ �����"), Order(4)]
    public void DiviOnePositiveInt()
    {
        int expected = a / -b;
        int actual = _calculator.Div(a, -b);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [Description("���� ��� ������� ���� ������������� ����� �����"), Order(4)]
    public void DiviTwoNegativeInt()
    {
        int expected = -a / -b;
        int actual = _calculator.Div(-a, -b);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [Description("���� ������� ����� �� ������ ���� ��� ����� �����"), Order(4)]
    public void DiviSelfInt()
    {
        int expected = b / b;
        int actual = _calculator.Div(b, b);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [Description("���� ��� ������� ���� ������������� ������������ �����"), Order(3)]
    [TestCase(5.0, 2.5, ExpectedResult = 2.0)]
    public double DivideTwoPositiveDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }

    [Test]
    [Description("���� ��� ������� ������ �������������� ������������� �����"), Order(6)]
    [Repeat(2)] //���� ����� ������� ������ ���������� �� ���������� ������� �������
    [TestCase(5.0, -2.5, ExpectedResult = -2.0)]
    public double DiviOnePositiveDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }

    [Test]
    [Description("���� ��� ������� ���� ������������� ������������ �����"), Order(4)]
    [Ignore("���� �� ����� �������")]
    [TestCase(-60.0, -2, ExpectedResult = 30.0)]
    public double DiviTwoNegativeDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }

    [Test]
    [Description("���� ������� ����� �� ������ ���� ��� ������������ �����"), Order(4)]
    [Retry(3)]//���� ����� �������� �� ���� ��� � ������ �������
    [TestCase(1.5, 1.5, ExpectedResult = 1.0)]
    public double DiviSelfDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }
}