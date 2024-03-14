/*
«адание 1:
–еализовать два метода Div(int a, int b) and Div(double a, double b) в классе Calculator
Ќаписать тесты на валидацию данных методов с использованием всех изученных атрибутов. ќб€зательно проверить деление на 0.
–ешение:
- “ест дл€ делени€ на 0
- “ест дл€ делени€ двух положительных целых / вещественных чисел
- “ест дл€ делени€ одного положительного и одного отрицательного целого/вещественное числа
- “ест дл€ делени€ двух отрицательных целых / вещественных чисел
- “ест делени€ числа на самого себ€ дл€ целых / вещественных чисел
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
    [Description("“ест дл€ делени€ на 0 int"), Order(1)]
    public void DivZeroInt()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Div(a, 0));
    }

    [Test]
    [Description("“ест дл€ делени€ на 0 double"), Order(2)]
    public void DivZeroDouble()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Div(c, 0.0));
    }

    [Test]
    [Description("“ест дл€ делени€ двух положительных целых чисел"), Order(3)]
    public void DiviTwoPositiveInt()
    {
        int expected = a / b;
        int actual = _calculator.Div(a, b);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    [Description("“ест дл€ делени€ одного положительного целого числа"), Order(4)]
    public void DiviOnePositiveInt()
    {
        int expected = a / -b;
        int actual = _calculator.Div(a, -b);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [Description("“ест дл€ делени€ двух отрицательных целых чисел"), Order(4)]
    public void DiviTwoNegativeInt()
    {
        int expected = -a / -b;
        int actual = _calculator.Div(-a, -b);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [Description("“ест делени€ числа на самого себ€ дл€ целых чисел"), Order(4)]
    public void DiviSelfInt()
    {
        int expected = b / b;
        int actual = _calculator.Div(b, b);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [Description("“ест дл€ делени€ двух положительных вещественных чисел"), Order(3)]
    [TestCase(5.0, 2.5, ExpectedResult = 2.0)]
    public double DivideTwoPositiveDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }

    [Test]
    [Description("“ест дл€ делени€ одного положительного вещественного числа"), Order(6)]
    [Repeat(2)] //тест будет запущен дважды независимо от результата первого запуска
    [TestCase(5.0, -2.5, ExpectedResult = -2.0)]
    public double DiviOnePositiveDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }

    [Test]
    [Description("“ест дл€ делени€ двух отрицательных вещественных чисел"), Order(4)]
    [Ignore("тест не будет запущен")]
    [TestCase(-60.0, -2, ExpectedResult = 30.0)]
    public double DiviTwoNegativeDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }

    [Test]
    [Description("“ест делени€ числа на самого себ€ дл€ вещественных чисел"), Order(4)]
    [Retry(3)]//тест будет повторен до трех раз в случае неудачи
    [TestCase(1.5, 1.5, ExpectedResult = 1.0)]
    public double DiviSelfDouble(double a, double b)
    {
        return _calculator.Div(a, b);
    }
}