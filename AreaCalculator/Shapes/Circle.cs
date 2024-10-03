using JetBrains.Annotations;

namespace AreaCalculator.Shapes;

[UsedImplicitly]
public class Circle(float radius) : IShape
{
    public float Radius { get; set; } = radius;

    public float GetArea()
    {
        return MathF.PI * MathF.Pow(Radius, 2);
    }
}