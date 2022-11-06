namespace Geometry.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(-10)]
    [InlineData(-0.01)]
    public void InvalidRadius_ThrowArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, Math.PI)]
    [InlineData(5, 78.53981634)]
    [InlineData(10.5, 346.3605900594)]
    public void GetSquare_ReturnCorrectSquare(double radius, double expectedSquare)
    {
        // Arrange
        var triangle = new Circle(radius);

        // Act
        var actualSquare = triangle.GetSquare();
        
        // Assert
        Assert.Equal(expectedSquare, actualSquare, 8);
    }
}