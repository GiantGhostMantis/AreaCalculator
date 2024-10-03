using JetBrains.Annotations;
using AreaCalculator.Shapes;

/*
    I really didn't know if it should be made as "library" (.dll) or console application or whatever. So I decided to 
    make it as .dll.
    Я не знал, должно ли приложение быть библиотекой классов (.dll) или каким-то другим видом приложения. Обычно под
    библиотекой имеют в виду библиотеку классов поэтому была сделана она.
*/

namespace AreaCalculator;

[UsedImplicitly]
public sealed class AreaCalculator
{
    [UsedImplicitly]
    public float GetCircleArea(float radius)
    {
        var circle = new Circle(radius);
        return circle.GetArea();
    }

    [UsedImplicitly]
    public float GetTriangleArea(float a, float b, float c)
    {
        var triangle = new Triangle(a, b, c);
        return triangle.GetArea();
    }

    [UsedImplicitly]
    public float GetShapeArea(IShape shape)
    {
        return shape.GetArea();
    }
}