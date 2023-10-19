using Mindbox.Lib;

namespace Mindbox.Tests;


[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void Should_True_When_NumbersGreaterZero_Method1()
    {
        Triangle triangle = new();
        triangle.Sides = new List<double> { 12, 6, 8 };

        CollectionAssert.AreEqual(new List<double> { 12, 6, 8 }, triangle.Sides);
    }
    [TestMethod]
    public void Should_True_When_NumbersGreaterZero_Method2()
    {
        Triangle triangle = new(new List<double> { 12, 6, 8 });

        CollectionAssert.AreEqual(new List<double> { 12, 6, 8 }, triangle.Sides);
    }
    public void Should_True_When_NumbersGreaterZero_Method3()
    {
        Triangle triangle = new(12, 6, 8 );

        CollectionAssert.AreEqual(new List<double> { 12, 6, 8 }, triangle.Sides);
    }

    [TestMethod]
    public void Should_ThrowsException_When_NumbersLessZero_Method1()
    {
        Triangle triangle = new();

        Assert.ThrowsException<ArgumentException>(() => triangle.Sides = new List<double> { 12, -6, 8 });
    }
    [TestMethod]
    public void Should_ThrowsException_When_NumbersLessZero_Method2()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(new List<double> { -12, 6, 8 }));
    }
    [TestMethod]
    public void Should_ThrowsException_When_NumbersLessZero_Method3()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(12, 6, -8 ));
    }

    [TestMethod]
    public void Should_ThrowsException_When_NumbersLess3()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(new List<double> { 6, 8 }));
    }
    [TestMethod]
    public void Should_ThrowsException_When_NumbersMore3()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(new List<double> { 6, 8, 12, 65 }));
    }

    [TestMethod]
    public void Should_21D3307_When_12And6And8()
    {
        Triangle triangle = new(new List<double> { 12, 6, 8 });

        Assert.AreEqual(21.3307, Math.Round(triangle.CalculateArea(), 4));
    }
    [TestMethod]
    public void Should_7D3101_When_2And8And9()
    {
        Triangle triangle = new(new List<double> { 2, 8, 9 });

        Assert.AreEqual(7.3101, Math.Round(triangle.CalculateArea(), 4));
    }

    [TestMethod]
    public void Should_True_When_5And12And13()
    {
        Triangle triangle = new(new List<double> { 5, 12, 13 });

        Assert.IsTrue(triangle.IsEquilateral());
    }
    [TestMethod]
    public void Should_False_When_5And5And8()
    {
        Triangle triangle = new(new List<double> { 5, 5, 8 });

        Assert.IsFalse(triangle.IsEquilateral());
    }
}
