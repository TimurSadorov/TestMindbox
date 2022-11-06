namespace Geometry.Tests.Helpers;

public class MessageHelper
{
    public static string GetMessageAboutNotEqualSquare(double expectedSquare, double actualSquare)
    {
        return $"Expected square: ${expectedSquare}, actual square: {actualSquare}";
    }
}