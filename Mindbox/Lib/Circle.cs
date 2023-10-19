using Mindbox.Lib.Base;

namespace Mindbox.Lib;


public class Circle : FigureBase
{
    private double r;

    public double R { get => r; set => r = value > 0 ? value : throw new ArgumentException("Invalid parameter"); }

    public Circle() { }
    public Circle(double radius) => R = radius;

    public override double CalculateArea()
    {
        return Math.PI * R * R;
    }
}