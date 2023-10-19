using Mindbox.Lib.Base;

namespace Mindbox.Lib;


public class Triangle : FigureBase
{
    private List<double> sides = new();

    public List<double> Sides
    {
        get => sides;
        set => sides = (value.Min() > 0 && value.Count == 3) ? value : throw new ArgumentException("Invalid parameter");
    }

    public Triangle() { }
    public Triangle(List<double> sides) => Sides = sides;
    public Triangle(double a, double b, double c) => Sides = new List<double> { a, b, c };

    public override double CalculateArea()
    {
        double p = sides.Sum() / 2;
        double result = p;
        foreach (double d in sides) { result *= p - d; }
        return Math.Sqrt(result);
    }

    public bool IsEquilateral()
    {
        sides.Sort();
        return sides[2] * sides[2] == sides[1] * sides[1] + sides[0] * sides[0];
    }
}
