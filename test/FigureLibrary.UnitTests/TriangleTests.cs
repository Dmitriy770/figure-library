namespace FigureLibrary.UnitTests;

public class TriangleTests
{
    [Theory]
    [InlineData(2, 3, 4, 2.9047375096555625)]
    [InlineData(20.1241, 40.124, 29.95, 291.35832717406254)]
    [InlineData(40.1241, 4.124, 43.95, 32.317737566371186)]
    public void Area_CalculateArea_Success(double a, double b, double c, double area)
    {
        //Arrange
        var triangle = new Triangle(a, b, c);

        //Act, Assert
        Assert.Equal(triangle.Area(), area, 5);
    }

    [Theory]
    [InlineData(2, 3, 4, false)]
    [InlineData(3, 4, 5, true)]
    [InlineData(3.5, 2.8, 2.1, true)]
    public void IsRight_Right_Success(double a, double b, double c, bool isRight)
    {
        //Arrange
        var triangle = new Triangle(a, b, c);

        //Act, Assert
        Assert.Equal(triangle.IsRight(), isRight);
    }

    [Theory]
    [InlineData(-2, 1, 1)]
    [InlineData(1, -2, 1)]
    [InlineData(1, 1, -2)]
    public void Constructor_NotValidArguments_Exception(double a, double b, double c)
    {
        //Act, //Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { new Triangle(a, b, c); });
    }

    [Theory]
    [InlineData(10, 1,1)]
    [InlineData(1, 10,1)]
    [InlineData(1, 1,10)]
    public void Constructor_NotValidTriangle_Exception(double a, double b, double c)
    {
        //Act, //Assert
        Assert.Throws<ArgumentException>(() => { new Triangle(a, b, c); });
    }
}