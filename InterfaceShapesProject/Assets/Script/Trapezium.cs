using UnityEngine;

public class Trapezium : IShape
{
    private float base1;
    private float base2;
    private float height;
    private float side1;
    private float side2;

    public Trapezium(float b1, float b2, float h, float s1, float s2)
    {
        base1 = b1;
        base2 = b2;
        height = h;
        side1 = s1;
        side2 = s2;
    }

    public float CalculateArea()
    {
        return 0.5f * (base1 + base2) * height;
    }

    public float CalculatePerimeter()
    {
        return base1 + base2 + side1 + side2;
    }
}