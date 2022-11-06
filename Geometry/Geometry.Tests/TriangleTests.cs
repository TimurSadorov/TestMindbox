using Geometry.Tests.Helpers;

namespace Geometry.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(-2, -2, -1)]
    [InlineData(0, 0, 0)]
    [InlineData(6, 3, 2)]
    [InlineData(4, 7, 2)]
    [InlineData(4, 3, 8)]
    [InlineData(2, 2, 4)]
    [InlineData(5.2, 2, 2)]
    public void InvalidSides_ThrowArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(6, 8, 10)]
    [InlineData(0.3, 0.4, 0.5)]
    [InlineData(0.6, 0.8, 1)]
    public void IsRectangular_RectangularTriangular_ReturnTrue(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var isRectangular = triangle.IsRectangular();

        // Assert
        Assert.True(isRectangular);
    }
    
    [Theory]
    [InlineData(3, 3, 3)]
    [InlineData(3.1, 4, 5)]
    [InlineData(2, 2, 1)]
    [InlineData(5, 6, 7)]
    public void IsRectangular_NotRectangularTriangular_ReturnFalse(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var isRectangular = triangle.IsRectangular();

        // Assert
        Assert.False(isRectangular);
    }
    
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 10, 12, 24.5446022579)]
    [InlineData(5.5, 8.2, 10, 22.5412675719)]
    [InlineData(15.3, 20.22, 28.5, 148.7789614515)]
    public void GetSquare_ReturnCorrectSquare(double a, double b, double c, double expectedSquare)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var actualSquare = triangle.GetSquare();
        
        // Assert
        var isEqual = ComparerHelper.DoubleIsEqual(actualSquare, expectedSquare, 1e-10);
        Assert.True(isEqual, MessageHelper.GetMessageAboutNotEqualSquare(expectedSquare, actualSquare));
    }
}