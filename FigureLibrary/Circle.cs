namespace FigureLibrary;

public class Circle : Figure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "Must be greater than zero.");
        }
        
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}