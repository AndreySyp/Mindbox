using Mindbox.Lib;

namespace Mindbox.Tests;


[TestClass]
public class CircleTest
{
    [TestMethod]
    public void Should_True_When_NumberGreaterZero_Method1()
    {
        Circle circle = new();
        circle.R = 1;

        Assert.AreEqual(1, circle.R);
    }
    [TestMethod]
    public void Should_True_When_NumberGreaterZero_Method2()
    {
        Circle circle = new(1);

        Assert.AreEqual(1, circle.R);
    }

    [TestMethod]
    public void Should_ThrowsException_When_NumberLessZero_Method1()
    {
        Circle circle = new();


        Assert.ThrowsException<ArgumentException>(() => circle.R = -10);
    }
    [TestMethod]
    public void Should_ThrowsException_When_NumberLessZero_Method2()
    {
        Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
    }

    [TestMethod]
    public void Should_1661D9025_When_23()
    {
        Circle circle = new(23);

        Assert.AreEqual(1661.9025, Math.Round(circle.CalculateArea(), 4));
    }
    [TestMethod]
    public void Should_0D7853_When_0D5()
    {
        Circle circle = new(0.5);

        Assert.AreEqual(0.7854, Math.Round(circle.CalculateArea(), 4));
    }
}
