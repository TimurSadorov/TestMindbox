namespace Geometry;

public class Circle: Figure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Negative radius");
        }

        Radius = radius;
    }
    
    public override double GetSquare()
    {
        return Radius * Radius * Math.PI;
    }
}