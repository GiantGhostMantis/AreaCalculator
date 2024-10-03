using AreaCalculator.Shapes;

namespace AreaCalculator.UnitTests.Tests;

public class TriangleTests
{
    private const float RightA = 5;
    private const float RightB = 4;
    private const float RightC = 3;
    private const float RightArea = 6;

    private const float A = 3;
    private const float B = 7;
    private const float C = 9;
    private const float Area = 8.786f;

    private const float FailureA = 3;
    private const float FailureB = 5;
    private const float FailureC = 10;

    private AreaCalculator _areaCalculator;

    [SetUp]
    public void Setup()
    {
        _areaCalculator = new AreaCalculator();
    }

    [Test]
    public void DynamicRightShapeGetAreaTest()
    {
        var methodRadius = _areaCalculator.GetShapeArea(new Triangle(RightA, RightB, RightC));
        Assert.That(MathF.Abs(methodRadius - RightArea), Is.LessThan(0.01f), "Area is not calculated correctly");
    }

    [Test]
    public void StaticRightShapeGetAreaTest()
    {
        var methodRadius = _areaCalculator.GetTriangleArea(RightA, RightB, RightC);
        Assert.That(MathF.Abs(methodRadius - RightArea), Is.LessThan(0.01f), "Area is not calculated correctly");
    }

    [Test]
    public void DynamicShapeGetAreaTest()
    {
        var methodRadius = _areaCalculator.GetShapeArea(new Triangle(A, B, C));
        Assert.That(MathF.Abs(methodRadius - Area), Is.LessThan(0.01f), "Area is not calculated correctly");
    }

    [Test]
    public void StaticShapeGetAreaTest()
    {
        var methodRadius = _areaCalculator.GetTriangleArea(A, B, C);
        Assert.That(MathF.Abs(methodRadius - Area), Is.LessThan(0.01f), "Area is not calculated correctly");
    }

    [Test]
    public void InputFailureText()
    {
        try
        {
            _areaCalculator.GetTriangleArea(FailureA, FailureB, FailureC);
            Assert.Fail("No exception was thrown");
        }
        catch (TriangleException)
        {
            Assert.Pass("Caught failed triangle exception");
        }
    }
}