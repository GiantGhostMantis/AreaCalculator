using AreaCalculator.Shapes;

namespace AreaCalculator.UnitTests.Tests;

public class CircleTests
{
    private readonly float Radius = 5;
    private readonly float Area = 78.53f;
    
    private AreaCalculator _areaCalculator;

    [SetUp]
    public void Setup()
    {
        _areaCalculator = new AreaCalculator();
    }

    [Test]
    public void DynamicShapeGetAreaTest()
    {
        var methodRadius = _areaCalculator.GetShapeArea(new Circle(Radius));
        Assert.That(MathF.Abs(methodRadius - Area), Is.LessThan(0.01f), "Area is not calculated correctly");
    }
    
    [Test]
    public void StaticShapeGetAreaTest()
    {
        var methodRadius = _areaCalculator.GetCircleArea(Radius);
        Assert.That(MathF.Abs(methodRadius - Area), Is.LessThan(0.01f), "Area is not calculated correctly");
    }
}