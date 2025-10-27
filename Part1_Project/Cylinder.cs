namespace Test1;

public class Cylinder(double radius, double height) : IShape
{
    private readonly double height = height;
    private readonly double radius = radius;

    public double CalculateArea()
    {
        return 2 * Math.PI * radius * (radius + height);
    }

    public double CalculateVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }
}