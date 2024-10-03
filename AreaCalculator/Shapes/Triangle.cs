using JetBrains.Annotations;

namespace AreaCalculator.Shapes;

[UsedImplicitly]
public class Triangle : IShape
{
    public float A { get; }
    public float B { get; }
    public float C { get; }

    public Triangle(float a, float b, float c)
    {
        if (a + b < c || b + c < a || c + a < b)
            throw new TriangleException($"Two of the sides must be bigger than the third one. Got input: {a}, {b}, {c}");

        A = a;
        B = b;
        C = c;
    }

    public float GetArea()
    {
        if (IsRightAngled(A, B, C))
            return A * B / 2;

        if (IsRightAngled(B, C, A))
            return B * C / 2;

        if (IsRightAngled(C, A, B))
            return C * A / 2;

        var s = (A + B + C) / 2;
        return MathF.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    private static bool IsRightAngled(float a, float b, float c)
    {
        return Math.Abs(MathF.Pow(a, 2) * MathF.Pow(b, 2) - MathF.Pow(c, 2)) < 0.01f;
    }
}

public class TriangleException(string message) : Exception(message);