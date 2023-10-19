using Mindbox.Lib;
using Mindbox.Lib.Base;

namespace Mindbox;


internal partial class Program
{    

    static void Main(string[] args)
    {
        List<FigureBase> figures = new()
        {
            new Circle(10),
            new Circle(6.4),
            new Triangle(2, 2, 1),
            new Triangle(new List<double> { 3, 4, 5 })
        };

        foreach (FigureBase fig in figures)
        {
            Console.WriteLine($"{fig.GetType()} = {fig.CalculateArea()}");
        }

    }
}