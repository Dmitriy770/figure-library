namespace FigureLibrary;

public class Triangle : Figure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public override double Area()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsRight()
    {
        var minSide = Math.Min(A, Math.Min(B, C));
        var maxSide = Math.Max(A, Math.Max(B, C));
        var meanSide = A + B + C - (minSide + maxSide);

        return Math.Pow(maxSide, 2).CompareTo(Math.Pow(minSide + meanSide, 2)) == 0;
    }
}