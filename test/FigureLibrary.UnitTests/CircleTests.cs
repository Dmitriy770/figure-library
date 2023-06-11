namespace FigureLibrary.UnitTests;

public class CircleTests
{
    [Theory]
    [InlineData(2.2141, 15.400837431638772)]
    [InlineData(5, 78.53981633974483)]
    [InlineData(100.2312, 31561.36170913434)]
    public void Area_CalculateArea_Success(double radius, double area)
    {
        //Arrange
        var circle = new Circle(radius);

        //Act, Assert
        Assert.Equal(circle.Area(), area, 5);
    }

    [Fact]
    public void Constructor_NotValidRadius_Exception()
    {
        //Arrange
        var radius = -50;

        //Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(radius); });
    }
}