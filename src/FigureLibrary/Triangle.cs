namespace FigureLibrary;

public class Triangle : Figure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a), "Must be greater than zero.");
        }

        if (b <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(b), "Must be greater than zero.");
        }

        if (c <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(c), "Must be greater than zero.");
        }

        var minSide = Math.Max(a, Math.Max(b, c));
        if (minSide >= a + b + c - minSide)
        {
            throw new ArgumentException("Not valid triangle.");
        }

        _a = a;
        _b = b;
        _c = c;
    }

    public override double Area()
    {
        var p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    public bool IsRight()
    {
        var minSide = Math.Min(_a, Math.Min(_b, _c));
        var maxSide = Math.Max(_a, Math.Max(_b, _c));
        var meanSide = _a + _b + _c - (minSide + maxSide);

        return Math.Abs(Math.Pow(maxSide, 2) - (Math.Pow(minSide, 2) + Math.Pow(meanSide, 2))) < 0.001;
    }
}