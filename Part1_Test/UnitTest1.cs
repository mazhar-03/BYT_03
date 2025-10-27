namespace Test1;

public class Tests
{
    private readonly IShape cube = new Cube(4);
    private readonly IShape cylinder = new Cylinder(3, 7);
    private readonly IShape rectangle = new Rectangle(4, 8);
    private readonly IShape sphere = new Sphere(5);


    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }

    //todo : Complete the remaning tests here
    [Test]
    public void TestCubeCalculateArea()
    {
        //6*16=96
        Assert.That(cube.CalculateArea(), Is.EqualTo(96));
    }

    [Test]
    public void TestCubeCalculateVolume()
    {
        //4^3=64
        Assert.That(cube.CalculateVolume(), Is.EqualTo(64));
    }

    [Test]
    public void TestCylinderCalculateArea()
    {
        //2*3,14*3*10
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        //3,14*9*7
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
    }

    [Test]
    public void TestRectangleCalculateArea()
    {
        //4*8
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(32));
    }

    [Test]
    public void TestRectangleCalculateVolume()
    {
        // For 2D shapes, volume is not applicable.
        // Height of 2D shape is 0, therefore volume is 0
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
    }
}