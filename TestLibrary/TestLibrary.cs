using NUnit.Framework;
using Library1;
using System;

[TestFixture]
public class MathOperationsTests
{
    private readonly MathOperations _mathOperations;

    public MathOperationsTests()
    {
        _mathOperations = new MathOperations();
    }

    [Test]
    public void Add_ShouldReturnCorrectResult()
    {
        int result = _mathOperations.Add(5, 10);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Subtract_ShouldReturnCorrectResult()
    {
        int result = _mathOperations.Subtract(10, 5);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Multiply_ShouldReturnCorrectResult()
    {
        int result = _mathOperations.Multiply(5, 4);
        Assert.AreEqual(20, result);
    }

    [Test]
    public void Divide_ShouldReturnCorrectResult()
    {
        double result = _mathOperations.Divide(10, 2);
        Assert.AreEqual(5.0, result);
    }

    [Test]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => _mathOperations.Divide(10, 0));
    }
}
