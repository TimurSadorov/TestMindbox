namespace Geometry;

public class Triangle : Figure
{
    public double A { get; }

    public double B { get; }

    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (!TriangleExist(a, b, c))
        {
            throw new ArgumentException($"There is no triangle with sides: {a}, {b}, {c}");
        }

        A = a;
        B = b;
        C = c;
    }

    public override double GetSquare()
    {
        var semiPerimeter = (A + B + C) / 2;
        return Math.Sqrt(
            semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
    }
    
    public bool IsRectangular()
    {
        var sortedSides = new[] {A, B, C}
            .OrderBy(side => side)
            .ToList();

        return sortedSides[0] * sortedSides[0] + sortedSides[1] * sortedSides[1]
            - sortedSides[2] * sortedSides[2] <= 1e-7;
    }

    private bool TriangleExist(double a, double b, double c)
    {
        return a + b > c && b + c > a && a + c > b;
    }
}