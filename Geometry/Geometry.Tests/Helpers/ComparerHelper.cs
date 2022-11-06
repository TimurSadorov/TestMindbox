namespace Geometry.Tests.Helpers;

public static class ComparerHelper
{
    public static bool DoubleIsEqual(double v1, double v2, double maxDeviation)
    {
        return Math.Abs(v1 - v2) < maxDeviation;
    }
}